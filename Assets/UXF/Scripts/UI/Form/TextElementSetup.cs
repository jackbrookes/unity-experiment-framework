using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UXF.UI
{
    [ExecuteAlways]
    public class TextElementSetup : MonoBehaviour
    {

        public InputField content;

        /// <summary>
        /// Awake is called when the script instance is being loaded.
        /// </summary>
        void Awake()
        {
            Func<object> get = () => { return content.text; };
            Action<object> set = (value) => { content.text = (string) value; };

            GetComponent<FormElement>().Initialise(get, set);
        }

    } 
}