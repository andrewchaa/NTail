﻿using NTail.Validation;
using Ninject.Modules;

namespace NTail
{
    public class NTailModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IArgumentValidator>().To<ArgumentMustBeProvidedValidator>();
            Bind<IArgumentValidator>().To<FileMustExistValidator>();
            Bind<IConsoleWriter>().To<ConsoleWriter>();
        }
    }
}
