 using Microsoft.AspNetCore.Components.Web;                                                                              
 using Microsoft.AspNetCore.Components.WebAssembly.Hosting;                                                              
 using Microsoft.Extensions.Configuration;                                                                               
 using Microsoft.Extensions.DependencyInjection;                                                                         
                                                                                                                         
 var builder = WebAssemblyHostBuilder.CreateDefault(args);                                                               
                                                                                                                         
 builder.Services.AddControllers();                                                                                      
 builder.Services.AddTransient<TemperatureConverter>();                                                                  
                                                                                                                         
 var host = builder.Build();                                                                                             
                                                                                                                         
 host.Run();
