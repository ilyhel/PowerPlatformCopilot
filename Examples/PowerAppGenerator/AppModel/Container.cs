﻿namespace PowerAppGenerator.AppModel;

public class Container : ControlInfo
{
    public Container(string name) : base(name)
    {
        Template = new Template
        {
            Id = "http://microsoft.com/appmagic/groupContainer",
            Version = "1.3.0",
            LastModifiedTimestamp = "0",
            Name = "groupContainer",
            FirstParty = true,
            IsPremiumPcfControl = false,
            IsCustomGroupControlTemplate = false,
            CustomGroupControlTemplateName = "",
            IsComponentDefinition = false,
            OverridableProperties = new OverridableProperties()
        };

        Index = 0.0f;
        VariantName = "verticalAutoLayoutContainer";
        LayoutName = "";
        MetaDataIDKey = "";
        PersistMetaDataIDKey = false;
        IsFromScreenLayout = false;
        StyleName = "defaultGroupContainerStyle";
        Parent = "";
        IsDataControl = false;
        AllowAccessToGlobals = true;
        IsGroupControl = false;
        IsAutoGenerated = false;
        IsLocked = false;

        #region Rules

        Rules.Add(new Rule { Property = "BorderColor", InvariantScript = "RGBA(0, 0, 0, 1)" });
        Rules.Add(new Rule { Property = "BorderStyle", InvariantScript = "BorderStyle.Solid" });
        Rules.Add(new Rule { Property = "Fill", InvariantScript = "RGBA(0, 0, 0, 0)" });
        Rules.Add(new Rule { Property = "X", InvariantScript = "30"
        });

        Rules.Add(new Rule
        {
            Property = "Y",
            InvariantScript = "30"
        });

        Rules.Add(new Rule
        {
            Property = "Width",
            InvariantScript = "Parent.Width - Self.X * 2"
        });

        Rules.Add(new Rule
        {
            Property = "Height",
            InvariantScript = "Parent.Height - Self.Y * 2"
        });

        Rules.Add(new Rule
        {
            Property = "DisplayMode",
            InvariantScript = "DisplayMode.Edit",
        });

        Rules.Add(new Rule
        {
            Property = "ChildTabPriority",
            InvariantScript = "true"
        });

        Rules.Add(new Rule
        {
            Property = "LayoutMode",
            InvariantScript = "LayoutMode.Auto"
        });

        Rules.Add(new Rule
        {
            Property = "LayoutDirection",
            InvariantScript = "LayoutDirection.Vertical"
        });

        Rules.Add(new Rule
        {
            Property = "LayoutAlignItems",
            InvariantScript = "LayoutAlignItems.Start"
        });

        Rules.Add(new Rule
        {
            Property = "LayoutJustifyContent",
            InvariantScript = "LayoutJustifyContent.Start"
        });

        Rules.Add(new Rule
        {
            Property = "LayoutGap",
            InvariantScript = "0"
        });

        Rules.Add(new Rule { Property = "LayoutOverflowX", InvariantScript = "LayoutOverflow.Hide" });
        Rules.Add(new Rule { Property = "LayoutOverflowY", InvariantScript = "LayoutOverflow.Scroll" });

        Rules.Add(new Rule
        {
            Property = "LayoutWrap",
            InvariantScript = "false"
        });

        Rules.Add(new Rule
        {
            Property = "DropShadow",
            InvariantScript = "DropShadow.Light"
        });

        Rules.Add(new Rule
        {
            Property = "ZIndex",
            InvariantScript = "1"
        });

        Rules.Add(new Rule
        {
            Property = "RadiusTopLeft",
            InvariantScript = "4"
        });

        Rules.Add(new Rule
        {
            Property = "RadiusTopRight",
            InvariantScript = "4"
        });

        Rules.Add(new Rule
        {
            Property = "RadiusBottomLeft",
            InvariantScript = "4"
        });

        Rules.Add(new Rule
        {
            Property = "RadiusBottomRight",
            InvariantScript = "4"
        });

        #endregion

        #region ControlPropertyState

        ControlPropertyState = new List<object>();
        ControlPropertyState.AddRange(new object[] {"BorderColor", "BorderStyle", "Fill", "X", "Y", "DisplayMode", "ChildTabPriority",
            "LayoutMode", "LayoutDirection", "LayoutAlignItems", "LayoutJustifyContent", "LayoutGap", "LayoutOverflowX", "LayoutOverflowY", "LayoutWrap",
            "DropShadow", "ZIndex", "RadiusTopLeft", "RadiusTopRight", "RadiusBottomLeft", "RadiusBottomRight" });

        ControlPropertyState.Add(new ComplexPropertyState()
        {
            InvariantPropertyName = "Width",
            AutoRuleBindingString = "500"
        });

        ControlPropertyState.Add(new ComplexPropertyState()
        {
            InvariantPropertyName = "Height",
            AutoRuleBindingString = "200"
        });

        #endregion
    }
}
