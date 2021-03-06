﻿using Catel.IoC;
using Catel.MVVM;
using CatelTest.Uwp.Ui.ViewModels;
using CatelTest.Uwp.Ui.Views;

namespace CatelTest.Uwp.Ui
{
    /// <summary>
    /// Used by the ModuleInit. All code inside the Initialize method is ran as soon as the assembly is loaded.
    /// </summary>
    public static class ModuleInitializer
    {
        /// <summary>
        /// Initializes the module.
        /// </summary>
        public static void Initialize()
        {
            var serviceLocator = ServiceLocator.Default;

            var viewLocator = serviceLocator.ResolveType<IViewLocator>();
            viewLocator.ClearCache();
            viewLocator.NamingConventions.Clear();

            var viewModelLocator = serviceLocator.ResolveType<IViewModelLocator>();
            viewModelLocator.ClearCache();
            viewModelLocator.NamingConventions.Clear();

            viewLocator.Register(typeof(PersonViewModel), typeof(PersonView));
            viewModelLocator.Register(typeof(PersonView), typeof(PersonViewModel));

            viewLocator.Register(typeof(AnotherViewModel), typeof(AnotherView));
            viewModelLocator.Register(typeof(AnotherView), typeof(AnotherViewModel));
        }
    }
}
