using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

namespace RPG.Core
{
    public interface IAction
    {
        void Cancel();
    }

}