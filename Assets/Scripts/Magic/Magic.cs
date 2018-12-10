using System;

namespace Magic
{
    /*TODO
     * Магія БАЗА -> Магія зачаровування ETC
     */
    public enum MAGIC_ATTRIBUTES
    {
        Froze, Fire, Lighting //MAIN
        //TODO Дописати типи магій: атакауючі(паралітична напр.)
    }
    
    public interface Magic
    {
        
    }

    public class MagicAttribute
    {
        private MAGIC_ATTRIBUTES[] Attributess;
        public MAGIC_ATTRIBUTES this[byte i]
        {
            get { return Attributess[i]; }
        }

        public MagicAttribute(params MAGIC_ATTRIBUTES[] attributess)
        {
            Attributess = new MAGIC_ATTRIBUTES[attributess.Length];
            Array.Copy(attributess,Attributess,attributess.Length);
        }
    }
}