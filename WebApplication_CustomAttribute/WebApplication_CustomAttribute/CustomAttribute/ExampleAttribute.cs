using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication_CustomAttribute.CustomAttribute
{
    public class ExampleAttribute : ValidationAttribute
    {
        private string[] m_Text;
        private string[] m_BaseText = new string[] { @"\", @"/", @"<", @">" };


        public ExampleAttribute()
        {
            m_Text = new string[] { };
        }
        
        public ExampleAttribute(string[] Text)
        {
            this.m_Text = Text;
        }
        
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string strValue = (string)value;
            string[] strBaseError = m_BaseText.Where(x => strValue.Contains(x)).ToArray();
            string[] strCustomError = m_Text.Where(x => strValue.Contains(x)).ToArray();

            if (strBaseError.Count() == 0 && strCustomError.Count() == 0)
            {
                return ValidationResult.Success;
            }
            else
            {
                List<string> temp = new List<string>();
                temp.AddRange(m_BaseText.ToList());
                temp.AddRange(m_Text.ToList());
                string errorMsg = $"禁止輸入 [{string.Join(", ", temp.ToArray())}] !!";
                return new ValidationResult(errorMsg);
            }
        }

    }
}