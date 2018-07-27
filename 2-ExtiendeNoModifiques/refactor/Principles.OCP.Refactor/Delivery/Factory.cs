using System.Collections.Generic;

namespace Principles.OCP.Refactor.Delivery
{
    class Factory
    {

        private Dictionary<CountryEnum, IDelivery> deliveryDictionary;

        #region Singleton pattern

        private static Factory instance;

        private Factory() {
            deliveryDictionary = new Dictionary<CountryEnum, IDelivery>();

            deliveryDictionary.Add(CountryEnum.Colombia, new ColombiaDelivery());
            deliveryDictionary.Add(CountryEnum.Mexico, new MexicoDelivery());
        }

        public static Factory Instance {
            get {
                if (instance == null) {
                    instance = new Factory();
                }
                return instance;
            }
        }

        #endregion

        public IDelivery Get(CountryEnum country) {

            IDelivery result = null;

            if (deliveryDictionary.ContainsKey(country)) {
                result = deliveryDictionary[country];
            }

            return result;

        }

    }
}
