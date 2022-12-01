using Inventory_Module.Data_Context;

namespace Inventory_Module.Code_Generator
{
    public class All_Code_Generation
    {
        ClsFunction _clsFunction;
        Inventory_Entity _context;

        public All_Code_Generation(Inventory_Entity context)
        {
            _context = context;    
        }

        public string client_code()
        {

            // initialization of ClsFunction() class using new keyword for memoery allocation.
            _clsFunction = new ClsFunction();

            // take _string as local variable to return a string.
            string _string = string.Empty;


            // x is used for assigning the table properties
            var Get_Client_Count=(from x in _context.Client_tbl
                                  select new
                                  {
                                      x.client_id
                                  }).Count();

            Get_Client_Count++;


            return _string = _clsFunction.code_create("HEX", Get_Client_Count.ToString());
        }
    }
}
