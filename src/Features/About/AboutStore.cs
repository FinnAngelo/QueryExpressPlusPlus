using Fluxor;
//using Microsoft.VisualBasic.ApplicationServices;
using System.Net.Http.Json;
using System.Reflection;
using static System.Net.WebRequestMethods;

namespace QueryExpressPlusPlus.Features.About.Store;

public record AboutState
(
    bool IsInitialized,
    bool IsLoading,
    string Title,
    string ProductName,
    string Version,
    string InformationalVersion,
    string Copyright,
    string CompanyName,
    string Description
);

public class AboutFeature : Feature<AboutState>
{
    public override string GetName() => "About";

    protected override AboutState GetInitialState()
    {
        return new AboutState
        (
            IsInitialized: false,
            IsLoading: false,
            Title: string.Empty,
            ProductName: string.Empty,
            Version: "",
            InformationalVersion: "",
            Copyright: string.Empty,
            CompanyName: string.Empty,
            Description: string.Empty
        );
    }
}

#region AboutActions
public record AboutSetIsInitializedAction { }
public record AboutLoadAssemblyInfoAction { }
public record AboutSetAssemblyInfoAction(
    string Title,
    string Version,
    string InformationalVersion,
    string Description,
    string Product,
    string Copyright,
    string Company);
public record AboutSetIsLoadingAction(bool IsLoading);

#endregion


public static class AboutReducers
{
    [ReducerMethod]
    public static AboutState OnSetAssemblyInfo(AboutState state, AboutSetAssemblyInfoAction action)
    {
        return state with
        {
            Title = action.Title,
            Version = action.Version,
            InformationalVersion = action.InformationalVersion,
            Description = action.Description,
            ProductName = action.Product,
            Copyright = action.Copyright,
            CompanyName = action.Company
        };
    }

    [ReducerMethod]
    public static AboutState OnSetLoading(AboutState state, AboutSetIsLoadingAction action)
    {
        return state with
        {
            IsLoading = action.IsLoading
        };
    }

    [ReducerMethod(typeof(AboutSetIsInitializedAction))]
    public static AboutState OnSetIsInitialized(AboutState state)
    {
        return state with
        {
            IsInitialized = true,
            IsLoading = false
        };
    }
}

public class AboutEffects
{
    private readonly Assembly _assembly;

    public AboutEffects(Assembly assembly)
    {
        _assembly = assembly;
    }

    [EffectMethod(typeof(AboutLoadAssemblyInfoAction))]
    public async Task LoadForecasts(IDispatcher dispatcher)
    {
        dispatcher.Dispatch(new AboutSetIsLoadingAction(true));

        // Yeah, this is a bit contrived, but I wanted the async
        await Task.Delay(5000);

        var action = new AboutSetAssemblyInfoAction(
            Title: $@"About {GetAssemblyTitle(_assembly)}",
            Version: $@"Version {GetAssemblyVersion(_assembly)}",
            InformationalVersion: GetAssemblyInformationalVersion(_assembly),
            Description: GetAssemblyDescription(_assembly),
            Product: GetAssemblyProduct(_assembly),
            Copyright: GetAssemblyCopyright(_assembly),
            Company: GetAssemblyCompany(_assembly));

        dispatcher.Dispatch(action);

        dispatcher.Dispatch(new AboutSetIsInitializedAction());
    }

    #region Assembly Attribute Accessors   

    public static string GetAssemblyTitle(Assembly assembly)
    {
        // Get all Title attributes on this assembly
        object[] attributes = assembly.GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
        // If there is at least one Title attribute
        if (attributes.Length > 0)
        {
            // Select the first one
            AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
            // If it is not an empty string, return it
            if (titleAttribute.Title != "")
                return titleAttribute.Title;
        }
        // If there was no Title attribute, or if the Title attribute was the empty string, return the .exe name
        return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().Location);
    }

    public static string GetAssemblyVersion(Assembly assembly)
    {
        return assembly.GetName().Version?.ToString() ?? "";
    }

    public static string GetAssemblyInformationalVersion(Assembly assembly)
    {
        // Get all Description attributes on this assembly
        var attributes = assembly
            .GetCustomAttributes(typeof(AssemblyInformationalVersionAttribute), false)
            .FirstOrDefault() as AssemblyInformationalVersionAttribute;
        // If there aren't any Description attributes, return an empty string
        if (attributes == null || attributes.IsDefaultAttribute())
            return "";

        // If there is a Description attribute, return its value
        return attributes.InformationalVersion;
    }

    public static string GetAssemblyDescription(Assembly assembly)
    {
        // Get all Description attributes on this assembly
        object[] attributes = assembly.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
        // If there aren't any Description attributes, return an empty string
        if (attributes.Length == 0)
            return "";
        // If there is a Description attribute, return its value
        return ((AssemblyDescriptionAttribute)attributes[0]).Description;
    }

    public static string GetAssemblyProduct(Assembly assembly)
    {
        // Get all Product attributes on this assembly
        object[] attributes = assembly.GetCustomAttributes(typeof(AssemblyProductAttribute), false);
        // If there aren't any Product attributes, return an empty string
        if (attributes.Length == 0)
            return "";
        // If there is a Product attribute, return its value
        return ((AssemblyProductAttribute)attributes[0]).Product;
    }

    public static string GetAssemblyCopyright(Assembly assembly)
    {
        // Get all Copyright attributes on this assembly
        object[] attributes = assembly.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
        // If there aren't any Copyright attributes, return an empty string
        if (attributes.Length == 0)
            return "";
        // If there is a Copyright attribute, return its value
        return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
    }

    public static string GetAssemblyCompany(Assembly assembly)
    {
        // Get all Company attributes on this assembly
        object[] attributes = assembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
        // If there aren't any Company attributes, return an empty string
        if (attributes.Length == 0)
            return "";
        // If there is a Company attribute, return its value
        return ((AssemblyCompanyAttribute)attributes[0]).Company;
    }

    #endregion
}

