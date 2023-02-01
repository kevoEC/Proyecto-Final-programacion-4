using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ProyectoFinalProgramacion4.Models;


namespace ProyectoFinalProgramacion4.Services
{
    public class FotoCall
    {
            public async Task<ReturnContent> GetFoto()
            {
                var api_key = "03f2MTA4MDM6Nzg0NjpmaWZ6UmN1dlFaazlac0d";
                var template_id = "b7a77b238845ca58";
                var url = $"https://rest.apitemplate.io/v2/create-pdf?template_id={template_id}";

                var data = new
                {
                    invoice_number = "INV38379",
                    date = "2021-09-30",
                    currency = "USD",
                    total_amount = 82542.56
                };
                var json_content = JsonSerializer.Serialize(data);
                var buffer = System.Text.Encoding.UTF8.GetBytes(json_content);
                var byteContent = new ByteArrayContent(buffer);

                var client = new HttpClient();
                client.DefaultRequestHeaders.Add("03f2MTA4MDM6Nzg0NjpmaWZ6UmN1dlFaazlac0d", api_key);
                var response = await client.PostAsync(url, byteContent);
                var ret = await response.Content.ReadAsStringAsync();

                var returnContent = JsonSerializer.Deserialize<ReturnContent>(ret);

                return returnContent;
            }
        }
 }

       

