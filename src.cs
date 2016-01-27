using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;
using UnityEngine.UI;



    public static class GameObjectUtil
    {
        public static Transform Transform(
            this string name)
        {
            return GameObject.Find(name).transform;
        }

        public static GameObject Find(
            this string name)
        {
            return GameObject.Find(name);
        }
        public static T Find<T>(
            this string name)
            where T : UnityEngine.Component
        {
            return GameObject.Find(name).GetComponent<T>();
        }
        public static T Find<T>(
            this Type type)
            where T : UnityEngine.Object
        {
            return GameObject.FindObjectOfType<T>();
        }

        public static void SetActive(
            this string name,
            bool value)
        {
            name.Find().SetActive(value);
        }
        public static void SetParent(
            this string child,
            string parent)
        {
            child.Transform().SetParent(parent.Transform());
        }
        public static void SetParent(
            this string child,
            GameObject parent)
        {
            child.Transform().SetParent(parent.transform);
        }
        public static void SetParent(
            this string child,
            Transform parent)
        {
            child.Transform().SetParent(parent);
        }

        public static string GetText(
            this string name)
        {
            return name.Find<Text>().text;
        }
        public static void SetText(
            this string name, string value)
        {
            name.Find<Text>().text = value;
        }

        public static bool IsOn(
            this string name)
        {
            return name.Find<Toggle>().isOn;
        }
        public static string GetSelectedOption(
            this string name)
        {
            var dropdown = name.Find<Dropdown>();
            return dropdown.options[dropdown.value].text;
        }
        public static int GetSelectedIndex(
            this string name)
        {
            var dropdown = name.Find<Dropdown>();
            return dropdown.value;
        }
    }
