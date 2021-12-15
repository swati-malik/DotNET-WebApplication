using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webApiFundamentals.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public static List<String> values = new List<string>()
        {
            "ValueOne","ValueTwo","123"
        };
        public List<String> GetValues()
        {
            return values;
        }
        [Route("{index}")]
        public string GetValue(int index)
        {
            return values[index];
        }
        [HttpPost]
        public void PostValue([FromBody]string value)
        {
            values.Add(value);
        }
        [Route("{Index}")]
        [HttpPut]
        public void PutValue(int index,[FromBody]string value)
        {
            values[index] = value;
        }
        [Route("{Index}")]
        [HttpDelete]
        public void Delete(int index)
        {
            values.RemoveAt(index);
        }

    }
}
