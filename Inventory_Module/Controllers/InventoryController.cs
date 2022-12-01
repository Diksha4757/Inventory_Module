using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Inventory_Module.Data_Context;
using Inventory_Module.Models;
using Inventory_Module.Code_Generator;
using Microsoft.EntityFrameworkCore;

namespace Inventory_Module.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
      public  Inventory_Entity _context;
        public InventoryController(Inventory_Entity context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Client_Info>>> GetEmployee()
        {
            return await _context.Client_tbl.ToListAsync();
        }

        [HttpPost]

        public async Task<ActionResult>Post_client(Client_Info model)
        {
            
            All_Code_Generation _all_Code_Generation = new All_Code_Generation(_context);
            

            // variable name                       // all_code_generation Method name client_code().
            string client_code = _all_Code_Generation.client_code();
             //model.client_code = client_code;
              //  property    // assigned variable.

           

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    // Genrating Global_id

                    // Random _random = new Random();
                    //int _global_id = _random.Next(100, 200);


                    Random _random = new Random();
                    int num = _random.Next(100,200);
                    int _global_id = num;

                    //int result = _global_id / 0;


                    Client_Info _client_Info = new Client_Info()
                    {


                        global_id = _global_id,
                        client_name = model.client_name,
                        client_code = client_code,
                        client_business_name = model.client_business_name,
                        client_GSTNo = model.client_GSTNo,
                        client_contact = model.client_contact,
                        client_reference_contact = model.client_reference_contact,
                        client_reference_name = model.client_reference_name,
                        client_business_description = model.client_business_description,
                        pincode = model.pincode,
                        country_code = model.country_code,
                        country_id = model.country_id,
                        state_id = model.state_id,
                        city_id = model.city_id,
                        client_logo = model.client_logo,
                        Pan_No = model.Pan_No,
                        IsDeleted = model.IsDeleted,
                        Client_Enrollment_Date = System.DateTime.Now,
                        Subscription_period = model.Subscription_period,


                    };
                    _context.Entry(_client_Info).State = EntityState.Added;
                    await _context.SaveChangesAsync();
                    return Ok(_client_Info);
                }
                catch (Exception ex)
                {
                  //  Log_maintain_class error_model = new Log_maintain_class();

                    string data = 
                                "name=" + model.client_name + 
                                ",client_code" + client_code + 
                                ",client_business_name=" + model.client_business_name + 
                                ",client_GSTNo=" + model.client_GSTNo +
                                ",client_contact=" + model.client_contact + 
                                ",client_reference_contact=" + model.client_reference_contact + 
                                ",client_reference_name=" + model.client_reference_name +
                                ",client_business_description=" + model.client_business_description + 
                                ",pincode=" + model.pincode + 
                                ",country_code=" + model.country_code + 
                                ",country_id=" + model.country_id +
                                ",state_id=" + model.state_id + 
                                ",city_id=" + model.city_id + 
                                ",client_logo=" + model.client_logo + 
                                ",Pan_No=" + model.Pan_No + 
                                ",IsDeleted=" + model.IsDeleted +
                                ",Client_Enrollment_Date=" + System.DateTime.Now + 
                                ",Subscription_period=" + model.Subscription_period;

                    if(ex.InnerException != null)
                    {
                        Log_maintain_class _log_Maintain_Class = new Log_maintain_class()
                        {
                            error_line_number=ex.StackTrace.ToString(),
                            error_trace = ex.StackTrace.ToString(),
                            error_messege = ex.ToString(),
                            error_inner_exception = ex.InnerException.ToString(),
                            error_data = data,
                            created_date = DateTime.Now,
                           
                           
                           

                            //error_line_number = error_model.error_line_number,
                            //error_trace = error_model.error_trace,
                            //error_messege = error_model.error_messege,
                            //error_inner_exception = error_model.error_inner_exception,
                            //error_data = data,
                            //created_date = System.DateTime.Now,

                        };
                        _context.Add(_log_Maintain_Class).State = EntityState.Added;
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        Log_maintain_class _log_Maintain_Class = new Log_maintain_class()
                        {
                            error_line_number = ex.StackTrace.ToString(),
                            error_trace = ex.StackTrace.ToString(),
                            error_messege = ex.ToString(),
                           // error_inner_exception = ex.InnerException.ToString(),
                            error_data = data,
                            created_date = DateTime.Now,
                        };
                        _context.Add(_log_Maintain_Class).State = EntityState.Added;
                        await _context.SaveChangesAsync();
                    }
                    
                  
                  // transaction.Rollback();
                    throw ex;

                }
                finally
                {
                    transaction.Commit();
                    transaction.Dispose();
                }
            }
        }
        
    }
}
