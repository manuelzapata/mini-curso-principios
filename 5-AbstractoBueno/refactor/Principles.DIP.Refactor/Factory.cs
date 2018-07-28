using System.Collections.Generic;

namespace Principles.DIP.Refactor
{
    class Factory
    {

        #region Singleton pattern

        private static Factory instance;

        private Factory() {}

        public static Factory Instance {
            get {
                if (instance == null) {
                    instance = new Factory();
                }
                return instance;
            }
        }

        #endregion

        public IProductRepository Get(string type) {

            IProductRepository result = null;

            switch (type)
            {
                case "default":
                    result = new ProductRepository();
                    break;
            }

            return result;

        }

    }
}
