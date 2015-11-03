// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using Microsoft.AspNet.Builder;

namespace Microsoft.AspNet.Routing
{
    public class RouteBuilder : IRouteBuilder
    {
        public RouteBuilder()
        {
            Routes = new List<IRouter>();
        }

        public IApplicationBuilder ApplicationBuilder { get; set; }

        public IInlineConstraintResolver ConstraintResolver { get; set; }

        public IRouteEndpoint DefaultHandler { get; set; }

        public IServiceProvider ServiceProvider { get; set; }

        public IList<IRouter> Routes
        {
            get;
            private set;
        }

        public IRouter Build()
        {
            var routeCollection = new RouteCollection();

            foreach (var route in Routes)
            {
                routeCollection.Add(route);
            }

            return routeCollection;
        }
    }
}