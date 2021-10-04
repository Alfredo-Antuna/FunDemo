using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FunDemo.Controllers
{
    [ApiController]
    [Route("api/fun")]
    public class FunController : ControllerBase
    {

        [HttpGet("convertToCentimeters/{num}")]
        public double ConvertInchesToCentimeters(double num)
        {
            return num * 2.54;
        }

        [HttpGet("convertToCelcius/{num}")]
        public double ConvertFaranheToCelcius(double num)
        {
            return (num - 32) * (0.5556);

        }

         [HttpGet("nameToArrayList/{num}/{name}")]
        public IEnumerable<string> NameToArray(int num, string name)
        {
            return Enumerable.Range(1, num).Select(index =>name + index).ToArray();
        }

        [HttpGet("reverseString/{word}")]
        public string ReverseString(string word)
        {
             char[] charArray = word.ToCharArray();
             Array.Reverse(charArray);
             return new string(charArray);
        }

        [HttpGet("showDog/{name}/{age}/{breed}")]
        public Dog ShowDog(string name, int age, string breed)
        {
             return new Dog{name = name, age = age, breed = breed};
        }

        [HttpGet("arrayOfshowDog/{name}/{age}/{breed}/{num}")]
        public IEnumerable<Dog> ArrayOfShowDog(string name, int age, string breed, int num)
        {  
             return Enumerable.Range(1, num).Select(index => new Dog{name = name, age = age, breed = breed}).ToArray();
        }

    }

    public class Dog
    {
       public string name{get; set;}
        public string breed{get; set;}
        public int age{get; set;}
    }
}
