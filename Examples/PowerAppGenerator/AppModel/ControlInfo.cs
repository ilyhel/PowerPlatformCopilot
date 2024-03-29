﻿using System.Text.Json.Serialization;

namespace PowerAppGenerator.AppModel;

public class Root
{
    [JsonPropertyName("TopParent")]
    public ControlInfo? ControlInfo { get; set; }
}

public class ControlInfo
{
    public ControlInfo(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentNullException(nameof(name));

        Name = name;
    }

    [JsonIgnore]
    public Rule? ZIndex { get; set; }

    [JsonIgnore]
    public Rule? Color { get; set; }

    [JsonIgnore]
    public Rule? Fill { get; set; }

    public string Type { get; set; } = "ControlInfo";
    public string Name { get; set; } = "";
    public bool HasDynamicProperties { get; set; } = false;
    public List<DynamicProperty>? DynamicProperties { get; set; }
    public Template Template { get; set; } = new();
    public double Index { get; set; }
    public double PublishOrderIndex { get; set; }
    public string VariantName { get; set; } = "";
    public string LayoutName { get; set; } = "";
    public string MetaDataIDKey { get; set; } = "";
    public bool PersistMetaDataIDKey { get; set; } = false;
    public bool IsFromScreenLayout { get; set; } = false;
    public string StyleName { get; set; } = "";
    public string Parent { get; set; } = "";
    public bool IsDataControl { get; set; } = false;
    public bool AllowAccessToGlobals { get; set; } = true;
    public bool IsGroupControl { get; set; } = false;
    public bool IsAutoGenerated { get; set; } = false;
    public List<Rule> Rules { get; set; } = new();
    public List<object> ControlPropertyState { get; set; } = new();
    public bool IsLocked { get; set; } = false;
    public string ControlUniqueId { get; set; } = "";
    public List<ControlInfo> Children { get; set; } = new();
}

public class Template
{
    public string Id { get; set; } = "http://microsoft.com/appmagic/screen";
    public string Version { get; set; } = "1.0";
    public string LastModifiedTimestamp { get; set; } = "0";
    public string Name { get; set; } = "screen";
    public bool FirstParty { get; set; } = true;
    public bool IsPremiumPcfControl { get; set; } = false;
    public bool IsCustomGroupControlTemplate { get; set; } = false;
    public string CustomGroupControlTemplateName { get; set; } = "";
    public bool IsComponentDefinition { get; set; } = false;
    public OverridableProperties OverridableProperties { get; set; } = new();
}

public class OverridableProperties
{
}

public class Rule
{
    public string Property { get; set; } = "";
    public string Category { get; set; } = "Design";
    public string InvariantScript { get; set; } = "";
    public string RuleProviderType { get; set; } = "Unknown";
}


public class DynamicProperty
{
    public string PropertyName { get; set; } = "";
    public Rule Rule { get; set; } = new();
    public string ControlPropertyState { get; set; } = "";
}
