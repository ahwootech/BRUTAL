namespace Brutal.FmodApi;

public partial struct ReverbProperties
{
    /// <summary>
    ///
    /// </summary>
    public static readonly ReverbProperties Off = new()
    {
        DecayTime = 1000,
        EarlyDelay = 7,
        LateDelay = 11,
        HfReference = 5000,
        HfDecayRatio = 100,
        Diffusion = 100,
        Density = 100,
        LowShelfFrequency = 250,
        LowShelfGain = 0,
        HighCut = 20,
        EarlyLateMix = 96,
        WetLevel = -80.0f,
    };

    /// <summary>
    ///
    /// </summary>
    public static readonly ReverbProperties Generic = new()
    {
        DecayTime = 1500,
        EarlyDelay = 7,
        LateDelay = 11,
        HfReference = 5000,
        HfDecayRatio = 83,
        Diffusion = 100,
        Density = 100,
        LowShelfFrequency = 250,
        LowShelfGain = 0,
        HighCut = 14500,
        EarlyLateMix = 96,
        WetLevel = -8.0f,
    };

    /// <summary>
    ///
    /// </summary>
    public static readonly ReverbProperties PaddedCell = new()
    {
        DecayTime = 170,
        EarlyDelay = 1,
        LateDelay = 2,
        HfReference = 5000,
        HfDecayRatio = 10,
        Diffusion = 100,
        Density = 100,
        LowShelfFrequency = 250,
        LowShelfGain = 0,
        HighCut = 160,
        EarlyLateMix = 84,
        WetLevel = -7.8f,
    };

    /// <summary>
    ///
    /// </summary>
    public static readonly ReverbProperties Room = new()
    {
        DecayTime = 400,
        EarlyDelay = 2,
        LateDelay = 3,
        HfReference = 5000,
        HfDecayRatio = 83,
        Diffusion = 100,
        Density = 100,
        LowShelfFrequency = 250,
        LowShelfGain = 0,
        HighCut = 6050,
        EarlyLateMix = 88,
        WetLevel = -9.4f,
    };

    /// <summary>
    ///
    /// </summary>
    public static readonly ReverbProperties Bathroom = new()
    {
        DecayTime = 1500,
        EarlyDelay = 7,
        LateDelay = 11,
        HfReference = 5000,
        HfDecayRatio = 54,
        Diffusion = 100,
        Density = 60,
        LowShelfFrequency = 250,
        LowShelfGain = 0,
        HighCut = 2900,
        EarlyLateMix = 83,
        WetLevel = 0.5f,
    };

    /// <summary>
    ///
    /// </summary>
    public static readonly ReverbProperties LivingRoom = new()
    {
        DecayTime = 500,
        EarlyDelay = 3,
        LateDelay = 4,
        HfReference = 5000,
        HfDecayRatio = 10,
        Diffusion = 100,
        Density = 100,
        LowShelfFrequency = 250,
        LowShelfGain = 0,
        HighCut = 160,
        EarlyLateMix = 58,
        WetLevel = -19.0f,
    };

    /// <summary>
    ///
    /// </summary>
    public static readonly ReverbProperties StoneRoom = new()
    {
        DecayTime = 2300,
        EarlyDelay = 12,
        LateDelay = 17,
        HfReference = 5000,
        HfDecayRatio = 64,
        Diffusion = 100,
        Density = 100,
        LowShelfFrequency = 250,
        LowShelfGain = 0,
        HighCut = 7800,
        EarlyLateMix = 71,
        WetLevel = -8.5f,
    };

    /// <summary>
    ///
    /// </summary>
    public static readonly ReverbProperties Auditorium = new()
    {
        DecayTime = 4300,
        EarlyDelay = 20,
        LateDelay = 30,
        HfReference = 5000,
        HfDecayRatio = 59,
        Diffusion = 100,
        Density = 100,
        LowShelfFrequency = 250,
        LowShelfGain = 0,
        HighCut = 5850,
        EarlyLateMix = 64,
        WetLevel = -11.7f,
    };

    /// <summary>
    ///
    /// </summary>
    public static readonly ReverbProperties ConcertHall = new()
    {
        DecayTime = 3900,
        EarlyDelay = 20,
        LateDelay = 29,
        HfReference = 5000,
        HfDecayRatio = 70,
        Diffusion = 100,
        Density = 100,
        LowShelfFrequency = 250,
        LowShelfGain = 0,
        HighCut = 5650,
        EarlyLateMix = 80,
        WetLevel = -9.8f,
    };

    /// <summary>
    ///
    /// </summary>
    public static readonly ReverbProperties Cave = new()
    {
        DecayTime = 2900,
        EarlyDelay = 15,
        LateDelay = 22,
        HfReference = 5000,
        HfDecayRatio = 100,
        Diffusion = 100,
        Density = 100,
        LowShelfFrequency = 250,
        LowShelfGain = 0,
        HighCut = 20000,
        EarlyLateMix = 59,
        WetLevel = -11.3f,
    };

    /// <summary>
    ///
    /// </summary>
    public static readonly ReverbProperties Arena = new()
    {
        DecayTime = 7200,
        EarlyDelay = 20,
        LateDelay = 30,
        HfReference = 5000,
        HfDecayRatio = 33,
        Diffusion = 100,
        Density = 100,
        LowShelfFrequency = 250,
        LowShelfGain = 0,
        HighCut = 4500,
        EarlyLateMix = 80,
        WetLevel = -9.6f,
    };

    /// <summary>
    ///
    /// </summary>
    public static readonly ReverbProperties Hangar = new()
    {
        DecayTime = 10000,
        EarlyDelay = 20,
        LateDelay = 30,
        HfReference = 5000,
        HfDecayRatio = 23,
        Diffusion = 100,
        Density = 100,
        LowShelfFrequency = 250,
        LowShelfGain = 0,
        HighCut = 3400,
        EarlyLateMix = 72,
        WetLevel = -7.4f,
    };

    /// <summary>
    ///
    /// </summary>
    public static readonly ReverbProperties CarpettedHallway = new()
    {
        DecayTime = 300,
        EarlyDelay = 2,
        LateDelay = 30,
        HfReference = 5000,
        HfDecayRatio = 10,
        Diffusion = 100,
        Density = 100,
        LowShelfFrequency = 250,
        LowShelfGain = 0,
        HighCut = 500,
        EarlyLateMix = 56,
        WetLevel = -24.0f,
    };

    /// <summary>
    ///
    /// </summary>
    public static readonly ReverbProperties Hallway = new()
    {
        DecayTime = 1500,
        EarlyDelay = 7,
        LateDelay = 11,
        HfReference = 5000,
        HfDecayRatio = 59,
        Diffusion = 100,
        Density = 100,
        LowShelfFrequency = 250,
        LowShelfGain = 0,
        HighCut = 7800,
        EarlyLateMix = 87,
        WetLevel = -5.5f,
    };

    /// <summary>
    ///
    /// </summary>
    public static readonly ReverbProperties StoneCorridor = new()
    {
        DecayTime = 270,
        EarlyDelay = 13,
        LateDelay = 20,
        HfReference = 5000,
        HfDecayRatio = 79,
        Diffusion = 100,
        Density = 100,
        LowShelfFrequency = 250,
        LowShelfGain = 0,
        HighCut = 9000,
        EarlyLateMix = 86,
        WetLevel = -6.0f,
    };

    /// <summary>
    ///
    /// </summary>
    public static readonly ReverbProperties Alley = new()
    {
        DecayTime = 1500,
        EarlyDelay = 7,
        LateDelay = 11,
        HfReference = 5000,
        HfDecayRatio = 86,
        Diffusion = 100,
        Density = 100,
        LowShelfFrequency = 250,
        LowShelfGain = 0,
        HighCut = 8300,
        EarlyLateMix = 80,
        WetLevel = -9.8f,
    };

    /// <summary>
    ///
    /// </summary>
    public static readonly ReverbProperties Forest = new()
    {
        DecayTime = 1500,
        EarlyDelay = 162,
        LateDelay = 88,
        HfReference = 5000,
        HfDecayRatio = 54,
        Diffusion = 79,
        Density = 100,
        LowShelfFrequency = 250,
        LowShelfGain = 0,
        HighCut = 760,
        EarlyLateMix = 94,
        WetLevel = -12.3f,
    };

    /// <summary>
    ///
    /// </summary>
    public static readonly ReverbProperties City = new()
    {
        DecayTime = 1500,
        EarlyDelay = 7,
        LateDelay = 11,
        HfReference = 5000,
        HfDecayRatio = 67,
        Diffusion = 50,
        Density = 100,
        LowShelfFrequency = 250,
        LowShelfGain = 0,
        HighCut = 4050,
        EarlyLateMix = 66,
        WetLevel = -26.0f,
    };

    /// <summary>
    ///
    /// </summary>
    public static readonly ReverbProperties Mountains = new()
    {
        DecayTime = 1500,
        EarlyDelay = 300,
        LateDelay = 100,
        HfReference = 5000,
        HfDecayRatio = 21,
        Diffusion = 27,
        Density = 100,
        LowShelfFrequency = 250,
        LowShelfGain = 0,
        HighCut = 1220,
        EarlyLateMix = 82,
        WetLevel = -24.0f,
    };

    /// <summary>
    ///
    /// </summary>
    public static readonly ReverbProperties Quarry = new()
    {
        DecayTime = 1500,
        EarlyDelay = 61,
        LateDelay = 25,
        HfReference = 5000,
        HfDecayRatio = 83,
        Diffusion = 100,
        Density = 100,
        LowShelfFrequency = 250,
        LowShelfGain = 0,
        HighCut = 3400,
        EarlyLateMix = 100,
        WetLevel = -5.0f,
    };

    /// <summary>
    ///
    /// </summary>
    public static readonly ReverbProperties Plain = new()
    {
        DecayTime = 1500,
        EarlyDelay = 179,
        LateDelay = 100,
        HfReference = 5000,
        HfDecayRatio = 50,
        Diffusion = 21,
        Density = 100,
        LowShelfFrequency = 250,
        LowShelfGain = 0,
        HighCut = 1670,
        EarlyLateMix = 65,
        WetLevel = -28.0f,
    };

    /// <summary>
    ///
    /// </summary>
    public static readonly ReverbProperties ParkingLot = new()
    {
        DecayTime = 1700,
        EarlyDelay = 8,
        LateDelay = 12,
        HfReference = 5000,
        HfDecayRatio = 100,
        Diffusion = 100,
        Density = 100,
        LowShelfFrequency = 250,
        LowShelfGain = 0,
        HighCut = 20000,
        EarlyLateMix = 56,
        WetLevel = -19.5f,
    };

    /// <summary>
    ///
    /// </summary>
    public static readonly ReverbProperties SewerPipe = new()
    {
        DecayTime = 2800,
        EarlyDelay = 14,
        LateDelay = 21,
        HfReference = 5000,
        HfDecayRatio = 14,
        Diffusion = 80,
        Density = 60,
        LowShelfFrequency = 250,
        LowShelfGain = 0,
        HighCut = 3400,
        EarlyLateMix = 66,
        WetLevel = 1.2f,
    };

    /// <summary>
    ///
    /// </summary>
    public static readonly ReverbProperties Underwater = new()
    {
        DecayTime = 1500,
        EarlyDelay = 7,
        LateDelay = 11,
        HfReference = 5000,
        HfDecayRatio = 10,
        Diffusion = 100,
        Density = 100,
        LowShelfFrequency = 250,
        LowShelfGain = 0,
        HighCut = 500,
        EarlyLateMix = 92,
        WetLevel = 7.0f,
    };
}

// #define FMOD_PRESET_OFF                             {  1000,    7,  11, 5000, 100, 100, 100, 250, 0,    20,  96, -80.0f }
// #define FMOD_PRESET_GENERIC                         {  1500,    7,  11, 5000,  83, 100, 100, 250, 0, 14500,  96,  -8.0f }
// #define FMOD_PRESET_PADDEDCELL                      {   170,    1,   2, 5000,  10, 100, 100, 250, 0,   160,  84,  -7.8f }
// #define FMOD_PRESET_ROOM                            {   400,    2,   3, 5000,  83, 100, 100, 250, 0,  6050,  88,  -9.4f }
// #define FMOD_PRESET_BATHROOM                        {  1500,    7,  11, 5000,  54, 100,  60, 250, 0,  2900,  83,   0.5f }
// #define FMOD_PRESET_LIVINGROOM                      {   500,    3,   4, 5000,  10, 100, 100, 250, 0,   160,  58, -19.0f }
// #define FMOD_PRESET_STONEROOM                       {  2300,   12,  17, 5000,  64, 100, 100, 250, 0,  7800,  71,  -8.5f }
// #define FMOD_PRESET_AUDITORIUM                      {  4300,   20,  30, 5000,  59, 100, 100, 250, 0,  5850,  64, -11.7f }
// #define FMOD_PRESET_CONCERTHALL                     {  3900,   20,  29, 5000,  70, 100, 100, 250, 0,  5650,  80,  -9.8f }
// #define FMOD_PRESET_CAVE                            {  2900,   15,  22, 5000, 100, 100, 100, 250, 0, 20000,  59, -11.3f }
// #define FMOD_PRESET_ARENA                           {  7200,   20,  30, 5000,  33, 100, 100, 250, 0,  4500,  80,  -9.6f }
// #define FMOD_PRESET_HANGAR                          { 10000,   20,  30, 5000,  23, 100, 100, 250, 0,  3400,  72,  -7.4f }
// #define FMOD_PRESET_CARPETTEDHALLWAY                {   300,    2,  30, 5000,  10, 100, 100, 250, 0,   500,  56, -24.0f }
// #define FMOD_PRESET_HALLWAY                         {  1500,    7,  11, 5000,  59, 100, 100, 250, 0,  7800,  87,  -5.5f }
// #define FMOD_PRESET_STONECORRIDOR                   {   270,   13,  20, 5000,  79, 100, 100, 250, 0,  9000,  86,  -6.0f }
// #define FMOD_PRESET_ALLEY                           {  1500,    7,  11, 5000,  86, 100, 100, 250, 0,  8300,  80,  -9.8f }
// #define FMOD_PRESET_FOREST                          {  1500,  162,  88, 5000,  54,  79, 100, 250, 0,   760,  94, -12.3f }
// #define FMOD_PRESET_CITY                            {  1500,    7,  11, 5000,  67,  50, 100, 250, 0,  4050,  66, -26.0f }
// #define FMOD_PRESET_MOUNTAINS                       {  1500,  300, 100, 5000,  21,  27, 100, 250, 0,  1220,  82, -24.0f }
// #define FMOD_PRESET_QUARRY                          {  1500,   61,  25, 5000,  83, 100, 100, 250, 0,  3400, 100,  -5.0f }
// #define FMOD_PRESET_PLAIN                           {  1500,  179, 100, 5000,  50,  21, 100, 250, 0,  1670,  65, -28.0f }
// #define FMOD_PRESET_PARKINGLOT                      {  1700,    8,  12, 5000, 100, 100, 100, 250, 0, 20000,  56, -19.5f }
// #define FMOD_PRESET_SEWERPIPE                       {  2800,   14,  21, 5000,  14,  80,  60, 250, 0,  3400,  66,   1.2f }
// #define FMOD_PRESET_UNDERWATER                      {  1500,    7,  11, 5000,  10, 100, 100, 250, 0,   500,  92,   7.0f }
