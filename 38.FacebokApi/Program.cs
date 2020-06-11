using System;
using Newtonsoft.Json;

//ejemplo api de facebook
namespace _38.FacebokApi{
    class Program{
        static void Main(string[] args){
            //token
            string fbtoken ="EAACpvZB0o0NMBANZBrJZBhOCEwQCAB6knvNsKKbjApjJALROgJBEs2Lzt2soGqZC7P15dxZAOdAPVJSJVCkNa50JlRUXnTpzd5SACEQm8eyO2vRRHCG2JZBch52tYj4GFYT4GkslO0zQSxXLphgZBpw4wgKMkj0gnpyZAzKuGzEORouZAAG24pSghQ9H5yH17sMwZD";
            string fbfields ="id,first_name,last_name,middle_name,name,name_format,picture,short_name,email";

            FacebokApi fb = new FacebokApi(fbtoken);

            string resultado = fb.ObtenerInfo(fbfields).Result;

            var res = JsonConvert.DeserializeObject(resultado);

            Console.WriteLine(res);
        }
    }
}
