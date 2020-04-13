using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLogic.Exceptions
{
    class CategoryNotFoundException: Exception
    {
        public string Category { get; private set; }
        public CategoryNotFoundException(string category): base($"Category {category} does not exist")
        {
        }
    }
}
