using System;

namespace DesignMode.PrototypePattern
{
    public abstract class Shape
    {
        private string id;
        private string type;

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public abstract string draw();



        public Object clone()
        {
            Object clone = null;
            try
            {
                clone = this.MemberwiseClone();
            }
            catch (Exception e)
            {
                throw e;
            }
            return clone;
        }
    }
}