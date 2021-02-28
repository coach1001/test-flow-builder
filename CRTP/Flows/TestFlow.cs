using CRTP.Models;
using CRTP.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using CRTP.DataModel;
using CRTP.Builders.TextControl;

namespace CRTP.Flows
{
    public class TestFlow
    {
        public static readonly FlowElement TestFlow1 = new FlowBuilder<FlowModel, FlowContextModel>("test-flow", "app-container")
                .AddStep(m => m.StepOne, "step-1")
                    .BuildRoute()
                        .AddStaticPath("path-1")
                    .EndRoute()
                    .Label("This is Step 1 of 2")
                    .SetNavigationButtonLabels(null,"Save","Next")
                    .AddControl(m=>m.StepOne.FieldOne)
                        .TextControl()
                        .EndTextcontrol()
                    .EndControl()
                .EndStep()
                .AddStep(m => m.StepTwo, "step-2")
                    .BuildRoute()
                        .AddStaticPath("path-2")
                    .EndRoute()
                    .Label("This is step 2 of 2")
                    .SetNavigationButtonLabels("Back", "Save", null)
                    .AddControl(m => m.StepTwo.FieldOne)
                        .TextControl()
                        .EndTextcontrol()
                    .EndControl()
                .EndStep()
            .Build();
    }
}
