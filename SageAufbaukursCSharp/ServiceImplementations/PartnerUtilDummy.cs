using SageAufbaukursCSharp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageAufbaukursCSharp.ServiceImplementations
{
    public class PartnerUtilDummy : IPartnerUtil
    {
        //public PartnerUtilDummy(bool DummyState) =>
        //    IsConnected = DummyState;

        //oder:
        public bool TestState { get; set; }

        public bool IsConnected {
            get
            {
                return TestState;
            }
        }
    }
    //früher:
    //public class PartnerUtilDummy : IPartnerUtil
    //{
    //    private bool _dummyState;
    //    public PartnerUtilDummy(bool DummyState)
    //    {
    //        _dummyState = DummyState;
    //    }

    //    bool IPartnerUtil.IsConnected => _dummyState;
    //}
}
