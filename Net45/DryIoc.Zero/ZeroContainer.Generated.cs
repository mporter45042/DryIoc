﻿

using System;
using System.Linq; // for Enumerable.Cast method required for LazyEnumerable<T>
using System.Collections.Generic;

namespace DryIoc.Zero
{
/* 
Exceptions happened during resolution:
======================================

======================================
end of exception list
*/

    partial class ZeroContainer
    {
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        partial void ResolveGenerated(ref object service, Type serviceType, IScope scope)
        {
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.A))
                service = Create_1(this, scope);

            else
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ISomeDb))
                service = Create_2(this, scope);

            else
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DbMan))
                service = Create_3(this, scope);

            else
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LazyDep))
                service = Create_7(this, scope);

            else
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IAnotherDb))
                service = Create_8(this, scope);

            else
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.B))
                service = Create_12(this, scope);
        }

        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        partial void ResolveGenerated(ref object service, Type serviceType, object serviceKey, IScope scope)
        {
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.MultiExported)) 
            {
                if ("c".Equals(serviceKey))
                    service = Create_4(this, scope);

                else
                if ("b".Equals(serviceKey))
                    service = Create_5(this, scope);

                else
                if ("a".Equals(serviceKey))
                    service = Create_6(this, scope);
            }

            else
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IMultiExported)) 
            {
                if ("c".Equals(serviceKey))
                    service = Create_9(this, scope);

                else
                if ("j".Equals(serviceKey))
                    service = Create_10(this, scope);

                else
                if ("i".Equals(serviceKey))
                    service = Create_11(this, scope);
            }
        }

        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        partial void ResolveManyGenerated(ref IEnumerable<KV> services, Type serviceType) 
        {
            services = ResolveManyGenerated(serviceType);
        }

        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        private IEnumerable<KV> ResolveManyGenerated(Type serviceType)
        {
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.A))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_1);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ISomeDb))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_2);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DbMan))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_3);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.MultiExported))
            {
                yield return new KV("c", (StatelessFactoryDelegate)Create_4);
                yield return new KV("b", (StatelessFactoryDelegate)Create_5);
                yield return new KV("a", (StatelessFactoryDelegate)Create_6);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LazyDep))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_7);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IAnotherDb))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_8);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IMultiExported))
            {
                yield return new KV("c", (StatelessFactoryDelegate)Create_9);
                yield return new KV("j", (StatelessFactoryDelegate)Create_10);
                yield return new KV("i", (StatelessFactoryDelegate)Create_11);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.B))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_12);
            }

        }

        internal static object Create_1(IResolverContext r, IScope scope)
        {
            return new DryIoc.MefAttributedModel.UnitTests.CUT.A();
        }

        internal static object Create_2(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(0, () => new DryIoc.MefAttributedModel.UnitTests.CUT.DbMan());
        }

        internal static object Create_3(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(0, () => new DryIoc.MefAttributedModel.UnitTests.CUT.DbMan());
        }

        internal static object Create_4(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(1, () => new DryIoc.MefAttributedModel.UnitTests.CUT.MultiExported());
        }

        internal static object Create_5(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(1, () => new DryIoc.MefAttributedModel.UnitTests.CUT.MultiExported());
        }

        internal static object Create_6(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(1, () => new DryIoc.MefAttributedModel.UnitTests.CUT.MultiExported());
        }

        internal static object Create_7(IResolverContext r, IScope scope)
        {
            return new DryIoc.MefAttributedModel.UnitTests.CUT.LazyDep();
        }

        internal static object Create_8(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(0, () => new DryIoc.MefAttributedModel.UnitTests.CUT.DbMan());
        }

        internal static object Create_9(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(1, () => new DryIoc.MefAttributedModel.UnitTests.CUT.MultiExported());
        }

        internal static object Create_10(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(1, () => new DryIoc.MefAttributedModel.UnitTests.CUT.MultiExported());
        }

        internal static object Create_11(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(1, () => new DryIoc.MefAttributedModel.UnitTests.CUT.MultiExported());
        }

        internal static object Create_12(IResolverContext r, IScope scope)
        {
            return new DryIoc.MefAttributedModel.UnitTests.CUT.B((DryIoc.MefAttributedModel.UnitTests.CUT.A)r.Resolver.ResolveKeyed(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.A), (object)null, DryIoc.IfUnresolved.Throw, default(System.Type), scope));
        }

    }
}