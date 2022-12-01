namespace Inventory_Module.Code_Generator
{
    public class ClsFunction
    {
        public string code_create(string _doctype,string _number)
        {
            if(_number.ToString().Length==1)
            {
                _number = "000" + _number;
            }
            else if(_number.ToString().Length==2)
            {
                _number = "00" + _number;
            }
            else if(_number.ToString().Length==3)
            {
                _number = "0" + _number;
            }
            return _doctype + _number;
        }
    }
}
