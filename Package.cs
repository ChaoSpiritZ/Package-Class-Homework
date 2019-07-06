using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package_Homework
{
    class Package
    {
        private int _packageNum;
        private int _senderNum;
        private int _recieverNum;
        private double _packageWeight;
        private string _deliveryType;
        private string _packageStatus;

        public int PackageNum
        {
            get
            {
                return _packageNum;
            }
        }

        public int SenderNum
        {
            get
            {
                return _senderNum;
            }
        }
        public int RecieverNum
        {
            get
            {
                return _recieverNum;
            }
        }

        public double PackageWeight
        {
            get
            {
                return _packageWeight;
            }
        }

        public string DeliveryType
        {
            get
            {
                return _deliveryType;
            }

            set
            {
                if(_deliveryType.ToLower() == "normal" || _deliveryType.ToLower() == "fast")
                {
                    _deliveryType = value;
                }
            }
        }

        public string PackageStatus
        {
            get
            {
                return _packageStatus;
            }
        }

        public Package(int packageNum, int senderNum, int recieverNum, double packageWeight, string deliveryType)
        {
            _packageNum = packageNum;
            _senderNum = senderNum;
            _recieverNum = recieverNum;
            _packageWeight = packageWeight;
            _deliveryType = deliveryType.ToLower();
            _packageStatus = "Not collected";
        }

        public double CalcPrice()
        {
            if(_deliveryType == "normal")
            {
                if(_packageWeight <= 2.0)
                {
                    return _packageWeight * 20;
                }
                else
                {
                    return ((_packageWeight - 2) * 10 + 40); //20 shekels from the first 2 kilograms = 40
                }
            }
            else
            {
                return (_packageWeight * 50);
            }
        }

        public void Collected()
        {
            _packageStatus = "Collected";
        }

        public bool Delivered()
        {
            if(_packageStatus == "Collected")
            {
                _packageStatus = "Delivered";
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
