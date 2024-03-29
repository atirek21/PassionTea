﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PassionTea.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PassionTea.Core.Extensions
{
    public static class ElementLocatorExtensions
    {
        public static IWebElement GetElement(this By elementLocator,IWebElement parentElement=null)
        {
            try
            {
                var element = parentElement ?? SeleniumExecutor.SearchContext;
                return element.FindElement(elementLocator);
            }
            catch(NoSuchElementException)
            {
                return null;
            }
            catch(TargetInvocationException)
            {
                return null;
            }
        }
        public static IWebElement GetElementWithWait(this By elementLocator)
        {
            Wait.ForElementToBeVisible(elementLocator);
            return elementLocator.GetElement();
        }
        public static void ClickWithWait(this By elementLocator)
        {
            elementLocator.GetElementWithWait().Click();
        }
        public static bool IsDisplayedAfterWait(this By elementLocator)
        {
            try
            {
                return elementLocator.GetElementWithWait().Displayed;
            }
            catch(WebDriverTimeoutException)
            {
                return false;
            }
        }
        public static bool IsDisplayed(this By elementLocator)
        {
            try
            {
                return elementLocator.GetElement().Displayed;
            }
            catch(WebDriverTimeoutException)
            {
                return false;
            }
        }
        public static void SendKeysWithWait(this By elementLocator,string text)
        {
            elementLocator.GetElementWithWait().SendKeys(text);
        }
        public static void SelectText(this By elementLocator,string text)
        {
            var select = elementLocator.GetSelectElement();
            select.SelectByText(text);
        }
        public static SelectElement GetSelectElement(this By elementsLocalization)
        {
            return new SelectElement(elementsLocalization.GetElementWithWait());
        }
    }
}
