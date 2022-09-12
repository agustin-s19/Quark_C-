using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poyecto43
{
    static class Utiles
    {

        public static Boolean validarCampo(string dato, string tipo){
        switch (tipo)
            {
                case "int":
                    try
                    {
                        Convert.ToInt32(dato);
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }

                case "float":
                    try
                    {
                        Convert.ToSingle(dato);
                        return true;
                    }
                    catch(Exception)
                    {
                        return false;
                    }
                case "string":
                    if (dato.Trim() != "")
                    {
                        try
                        {
                            Convert.ToString(dato.Trim());
                            return true;
                        }
                        catch (Exception)
                        {
                            return false;
                        }

                    }
                    else { 
                        return false;
                    }
                default:
                    return false;
            }

           
        }
    }
}
