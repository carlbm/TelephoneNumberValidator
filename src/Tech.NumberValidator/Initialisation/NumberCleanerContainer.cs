using System;
using System.Collections.Generic;
using System.Threading;
using DryIoc;
using Tech.NumberValidator.NumberCleaners;

namespace Tech.NumberValidator.Initialisation
{
    static class NumberCleanerContainer
    {
        private static readonly Lazy<IContainer> Container = new Lazy<IContainer>(() =>
        {
            var container = new Container();
            container.RegisterMany(new [] {typeof(INumberCleaner).Assembly}, 
                serviceTypeCondition: type => type == typeof(INumberCleaner), 
                reuse:Reuse.Singleton, 
                nonPublicServiceTypes:true);

            return container;
        }, LazyThreadSafetyMode.ExecutionAndPublication);

        public static IReadOnlyList<T> ResolveAll<T>() => Container.Value.Resolve<IReadOnlyList<T>>();
    }
}
