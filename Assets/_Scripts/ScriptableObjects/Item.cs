
using UnityEngine;

namespace GameUtils
{
    namespace ItemSystem
    {
        public abstract class Item : ScriptableObject
        {
            [SerializeField]
            protected string itemName;
            [SerializeField]
            protected Sprite itemSprite;
            [SerializeField]
            protected string description;
            [SerializeField]
            protected int saleValue;

            public string Description
            {
                get
                {
                    return description;
                }

                set
                {
                    description = value;
                }
            }

            public int SaleValue
            {
                get
                {
                    return saleValue;
                }

                set
                {
                    saleValue = value;
                }
            }

            protected Sprite ItemSprite
            {
                get
                {
                    return itemSprite;
                }

                set
                {
                    itemSprite = value;
                }
            }

            protected string ItemName
            {
                get
                {
                    return itemName;
                }

                set
                {
                    itemName = value;
                }
            }
        }
    }
}
