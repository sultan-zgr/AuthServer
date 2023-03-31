using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Dtos
{
    public class ErrorDTO
    {
        public List<String> Errors { get; private set; }
        public bool IsShow { get; set; }
        public ErrorDTO()
        {
            Errors = new List<String>();
        }
        public ErrorDTO(string error, bool isShow)
        {
            Errors.Add(error);
            isShow = true;
        }
        public ErrorDTO(List<string> errors, bool isShow)
        {
            Errors = errors;
            IsShow = isShow;
        }
    }
}
