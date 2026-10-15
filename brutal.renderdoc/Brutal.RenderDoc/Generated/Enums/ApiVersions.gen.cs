namespace Brutal.RenderDocApi;

/// RenderDoc uses semantic versioning (http://semver.org/).
/// MAJOR version is incremented when incompatible API changes happen.
/// MINOR version is incremented when functionality is added in a backwards-compatible manner.
/// PATCH version is incremented when backwards-compatible bug fixes happen.
/// Note that this means the API returned can be higher than the one you might have requested.
/// e.g. if you are running against a newer RenderDoc that supports 1.0.1, it will be returned
/// instead of 1.0.0. You can check this with the GetAPIVersion entry point
public enum ApiVersions : int
{
    /// eRENDERDOC_API_Version_1_0_0
    V1_0_0 = 10000,

    /// eRENDERDOC_API_Version_1_0_1
    V1_0_1 = 10001,

    /// eRENDERDOC_API_Version_1_0_2
    V1_0_2 = 10002,

    /// eRENDERDOC_API_Version_1_1_0
    V1_1_0 = 10100,

    /// eRENDERDOC_API_Version_1_1_1
    V1_1_1 = 10101,

    /// eRENDERDOC_API_Version_1_1_2
    V1_1_2 = 10102,

    /// eRENDERDOC_API_Version_1_2_0
    V1_2_0 = 10200,

    /// eRENDERDOC_API_Version_1_3_0
    V1_3_0 = 10300,

    /// eRENDERDOC_API_Version_1_4_0
    V1_4_0 = 10400,

    /// eRENDERDOC_API_Version_1_4_1
    V1_4_1 = 10401,

    /// eRENDERDOC_API_Version_1_4_2
    V1_4_2 = 10402,

    /// eRENDERDOC_API_Version_1_5_0
    V1_5_0 = 10500,

    /// eRENDERDOC_API_Version_1_6_0
    V1_6_0 = 10600,
}
