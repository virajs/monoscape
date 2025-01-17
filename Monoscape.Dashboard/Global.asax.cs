/*
 *  Copyright 2013 Monoscape
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 *
 *  History: 
 *  2011/11/10 Imesh Gunaratne <imesh@monoscape.org> Created.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Configuration;
using Monoscape.Dashboard.Models;
using Monoscape.Dashboard.Runtime;

namespace Monoscape.Dashboard
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
			
            // Cloud Controller Starts
			routes.MapRoute(
                "CloudControllerAddApplicationSubscription", // Route name
                "cloudcontroller/addapplicationsubscription", // URL with parameters
                new { controller = "CloudController", action = "AddApplicationSubscription" } // Parameter defaults
            );
			routes.MapRoute(
                "CloudControllerAddExSystemSubscription", // Route name
                "cloudcontroller/addexsystemsubscription", // URL with parameters
                new { controller = "CloudController", action = "AddExSystemSubscription" } // Parameter defaults
            );
            routes.MapRoute(
                "CloudControllerRemoveSubscription", // Route name
                "cloudcontroller/subscription/{subscriptionId}/remove", // URL with parameters
                new { controller = "CloudController", action = "RemoveSubscription" } // Parameter defaults
            );
            routes.MapRoute(
                "CloudControllerSubscription", // Route name
                "cloudcontroller/subscription/{subscriptionId}", // URL with parameters
                new { controller = "CloudController", action = "Subscription" } // Parameter defaults
            );
            // Cloud Controller Ends

			// Application Grid Start
			// Query Methods Start
 			routes.MapRoute(
                "ApplicationGridApplications", // Route name
                "applicationgrid/applications", // URL with parameters
                new { controller = "ApplicationGrid", action = "Applications" } // Parameter defaults
            );
            routes.MapRoute(
                "ApplicationGridApplicationInfo", // Route name
                "applicationgrid/application/{applicationId}", // URL with parameters
                new { controller = "ApplicationGrid", action = "ApplicationInfo" } // Parameter defaults
            );
			routes.MapRoute(
                "ApplicationGridApplicationInstances", // Route name
                "applicationgrid/applicationinstances", // URL with parameters
                new { controller = "ApplicationGrid", action = "ApplicationInstances" } // Parameter defaults
            ); 
			routes.MapRoute(
                "ApplicationGridImages", // Route name
                "applicationgrid/images", // URL with parameters
                new { controller = "ApplicationGrid", action = "Images" } // Parameter defaults
            );
			routes.MapRoute(
                "ApplicationGridInstaces", // Route name
                "applicationgrid/instances", // URL with parameters
                new { controller = "ApplicationGrid", action = "Instances" } // Parameter defaults
            ); 
			routes.MapRoute(
                "ApplicationGridNodes", // Route name
                "applicationgrid/nodes", // URL with parameters
                new { controller = "ApplicationGrid", action = "Nodes" } // Parameter defaults
            );
			// Query Methods End			
			// Actions Start
			routes.MapRoute(
                "ApplicationGridRunInstance", // Route name
                "applicationgrid/runinstance/{imageId}", // URL with parameters
                new { controller = "ApplicationGrid", action = "RunInstance" } // Parameter defaults
            );
			routes.MapRoute(
                "ApplicationGridStartApplication", // Route name
                "applicationgrid/startapplication/{applicationId}", // URL with parameters
                new { controller = "ApplicationGrid", action = "StartApplication" } // Parameter defaults
            );
            routes.MapRoute(
                "ApplicationGridStopApplicationInstance", // Route name
                "applicationgrid/stopapplicationinstance/{nodeId}-{applicationId}-{instanceId}", // URL with parameters
                new { controller = "ApplicationGrid", action = "StopApplicationInstance" } // Parameter defaults
            );
            routes.MapRoute(
                "ApplicationGridDeregisterImage", // Route name
                "applicationgrid/deregisterimage/{imageId}", // URL with parameters
                new { controller = "ApplicationGrid", action = "DeregisterImage" } // Parameter defaults
            );
            routes.MapRoute(
                "ApplicationGridAssignPublicIp", // Route name
                "applicationgrid/assignpublicip/{instanceId}", // URL with parameters
                new { controller = "ApplicationGrid", action = "AssignPublicIp" } // Parameter defaults
            );
            routes.MapRoute(
                "ApplicationGridTerminateInstance", // Route name
                "applicationgrid/terminateinstance/{instanceId}", // URL with parameters
                new { controller = "ApplicationGrid", action = "TerminateInstance" } // Parameter defaults
            );
            routes.MapRoute(
                "ApplicationGridRebootInstance", // Route name
                "applicationgrid/rebootinstance/{instanceId}", // URL with parameters
                new { controller = "ApplicationGrid", action = "RebootInstance" } // Parameter defaults
            );
            routes.MapRoute(
                "ApplicationGridConsoleOutput", // Route name
                "applicationgrid/consoleoutput/{instanceId}", // URL with parameters
                new { controller = "ApplicationGrid", action = "ConsoleOutput" } // Parameter defaults
            );
			routes.MapRoute(
                "ApplicationGridUploadApplication", // Route name
                "applicationgrid/uploadapplication", // URL with parameters
                new { controller = "ApplicationGrid", action = "UploadApplication" } // Parameter defaults
            );
			routes.MapRoute(
                "ApplicationGridRemoveApplication", // Route name
                "applicationgrid/removeapplication/{applicationId}", // URL with parameters
                new { controller = "ApplicationGrid", action = "RemoveApplication" } // Parameter defaults
            );

			// Application Grid Ends
			
			// Load Balancer Start
			routes.MapRoute(
                "LoadBalancerRequestQueue", // Route name
                "loadbalancer/requestqueue", // URL with parameters
                new { controller = "LoadBalancer", action = "RequestQueue" } // Parameter defaults
            );
			routes.MapRoute(
                "LoadBalancerRequestHistory", // Route name
                "loadbalancer/requesthistory", // URL with parameters
                new { controller = "LoadBalancer", action = "RequestHistory" } // Parameter defaults
            );
		    routes.MapRoute(
                "LoadBalancerRoutingMeshHistory", // Route name
                "loadbalancer/routingmeshhistory", // URL with parameters
                new { controller = "LoadBalancer", action = "RoutingMeshHistory" } // Parameter defaults
            );
			// Load Balancer Ends
			
			// Main Pages Start
			routes.MapRoute(
                "CloudControllerIndex", // Route name
                "cloudcontroller", // URL with parameters
                new { controller = "CloudController", action = "Index" } // Parameter defaults
            );
            routes.MapRoute(
                "ApplicationGridIndex", // Route name
                "applicationgrid", // URL with parameters
                new { controller = "ApplicationGrid", action = "Index" } // Parameter defaults
            );
			routes.MapRoute(
                "LoadBalancerIndex", // Route name
                "loadbalancer", // URL with parameters
                new { controller = "LoadBalancer", action = "Index" } // Parameter defaults
            );
			routes.MapRoute(
                "HomeAbout", // Route name
                "about", // URL with parameters
                new { controller = "Home", action = "About" } // Parameter defaults
            );
			// Main Pages End
            
            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RegisterRoutes(RouteTable.Routes);            
            Initializer.Initialize(this);
        }
    }
}
