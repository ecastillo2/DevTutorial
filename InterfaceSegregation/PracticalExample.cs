namespace InterfaceSegregation.PracticalExample;

/// <summary>
/// PRACTICAL EXAMPLE - Smart Home System
/// Demonstrates ISP in a real-world IoT scenario
/// </summary>

// ========== DEVICE CAPABILITIES ==========

/// <summary>
/// Basic device interface - all devices have these
/// </summary>
public interface IDevice
{
    string DeviceId { get; }
    string Name { get; }
    bool IsOnline { get; }
    void Connect();
    void Disconnect();
    DeviceStatus GetStatus();
}

/// <summary>
/// Devices that can be turned on/off
/// </summary>
public interface ISwitchable
{
    bool IsOn { get; }
    void TurnOn();
    void TurnOff();
}

/// <summary>
/// Devices with adjustable settings
/// </summary>
public interface IAdjustable
{
    int GetLevel();
    void SetLevel(int level);
    int MaxLevel { get; }
}

/// <summary>
/// Devices that can change color
/// </summary>
public interface IColorChangeable
{
    Color CurrentColor { get; }
    void SetColor(Color color);
    List<Color> GetSupportedColors();
}

/// <summary>
/// Devices with temperature control
/// </summary>
public interface ITemperatureControl
{
    double GetCurrentTemperature();
    double GetTargetTemperature();
    void SetTargetTemperature(double temperature);
    (double min, double max) GetTemperatureRange();
}

/// <summary>
/// Devices that can monitor environment
/// </summary>
public interface IEnvironmentMonitor
{
    double GetHumidity();
    double GetTemperature();
    double GetAirQuality();
}

/// <summary>
/// Devices with motion detection
/// </summary>
public interface IMotionDetector
{
    bool IsMotionDetected();
    void SetSensitivity(int level);
    event EventHandler<MotionEventArgs> MotionDetected;
}

/// <summary>
/// Devices that can capture media
/// </summary>
public interface IMediaCapture
{
    void TakePhoto();
    void StartRecording();
    void StopRecording();
    byte[] GetLastCapture();
}

/// <summary>
/// Devices with scheduling capability
/// </summary>
public interface ISchedulable
{
    void AddSchedule(Schedule schedule);
    void RemoveSchedule(string scheduleId);
    List<Schedule> GetSchedules();
}

/// <summary>
/// Devices that can play audio
/// </summary>
public interface IAudioPlayer
{
    void PlayAudio(string source);
    void StopAudio();
    void SetVolume(int volume);
    int GetVolume();
}

/// <summary>
/// Devices with security features
/// </summary>
public interface ISecurityDevice
{
    void Arm();
    void Disarm(string code);
    bool IsArmed { get; }
    void TriggerAlarm();
}

// ========== DEVICE IMPLEMENTATIONS ==========

/// <summary>
/// Smart Light - switchable, adjustable brightness, and color
/// </summary>
public class SmartLight : IDevice, ISwitchable, IAdjustable, IColorChangeable, ISchedulable
{
    public string DeviceId { get; }
    public string Name { get; }
    public bool IsOnline { get; private set; }
    public bool IsOn { get; private set; }
    public int MaxLevel => 100;
    public Color CurrentColor { get; private set; }
    
    private int brightness = 100;
    private readonly List<Schedule> schedules = new List<Schedule>();

    public SmartLight(string deviceId, string name)
    {
        DeviceId = deviceId;
        Name = name;
        CurrentColor = Color.White;
    }

    public void Connect()
    {
        IsOnline = true;
        Console.WriteLine($"Smart Light '{Name}' connected");
    }

    public void Disconnect()
    {
        IsOnline = false;
        Console.WriteLine($"Smart Light '{Name}' disconnected");
    }

    public DeviceStatus GetStatus()
    {
        return new DeviceStatus
        {
            DeviceId = DeviceId,
            IsOnline = IsOnline,
            Properties = new Dictionary<string, object>
            {
                ["IsOn"] = IsOn,
                ["Brightness"] = brightness,
                ["Color"] = CurrentColor.ToString()
            }
        };
    }

    public void TurnOn()
    {
        IsOn = true;
        Console.WriteLine($"Light '{Name}' turned on");
    }

    public void TurnOff()
    {
        IsOn = false;
        Console.WriteLine($"Light '{Name}' turned off");
    }

    public int GetLevel()
    {
        return brightness;
    }

    public void SetLevel(int level)
    {
        brightness = Math.Clamp(level, 0, MaxLevel);
        Console.WriteLine($"Light '{Name}' brightness set to {brightness}%");
    }

    public void SetColor(Color color)
    {
        CurrentColor = color;
        Console.WriteLine($"Light '{Name}' color changed to {color}");
    }

    public List<Color> GetSupportedColors()
    {
        return Enum.GetValues<Color>().ToList();
    }

    public void AddSchedule(Schedule schedule)
    {
        schedules.Add(schedule);
        Console.WriteLine($"Schedule added to light '{Name}'");
    }

    public void RemoveSchedule(string scheduleId)
    {
        schedules.RemoveAll(s => s.Id == scheduleId);
    }

    public List<Schedule> GetSchedules()
    {
        return new List<Schedule>(schedules);
    }
}

/// <summary>
/// Smart Thermostat - temperature control and scheduling
/// </summary>
public class SmartThermostat : IDevice, ISwitchable, ITemperatureControl, ISchedulable, IEnvironmentMonitor
{
    public string DeviceId { get; }
    public string Name { get; }
    public bool IsOnline { get; private set; }
    public bool IsOn { get; private set; }
    
    private double targetTemperature = 22.0;
    private double currentTemperature = 21.5;
    private double humidity = 45.0;
    private readonly List<Schedule> schedules = new List<Schedule>();

    public SmartThermostat(string deviceId, string name)
    {
        DeviceId = deviceId;
        Name = name;
    }

    public void Connect()
    {
        IsOnline = true;
        Console.WriteLine($"Thermostat '{Name}' connected");
    }

    public void Disconnect()
    {
        IsOnline = false;
        Console.WriteLine($"Thermostat '{Name}' disconnected");
    }

    public DeviceStatus GetStatus()
    {
        return new DeviceStatus
        {
            DeviceId = DeviceId,
            IsOnline = IsOnline,
            Properties = new Dictionary<string, object>
            {
                ["IsOn"] = IsOn,
                ["CurrentTemp"] = currentTemperature,
                ["TargetTemp"] = targetTemperature,
                ["Humidity"] = humidity
            }
        };
    }

    public void TurnOn()
    {
        IsOn = true;
        Console.WriteLine($"Thermostat '{Name}' activated");
    }

    public void TurnOff()
    {
        IsOn = false;
        Console.WriteLine($"Thermostat '{Name}' deactivated");
    }

    public double GetCurrentTemperature()
    {
        return currentTemperature;
    }

    public double GetTargetTemperature()
    {
        return targetTemperature;
    }

    public void SetTargetTemperature(double temperature)
    {
        var (min, max) = GetTemperatureRange();
        targetTemperature = Math.Clamp(temperature, min, max);
        Console.WriteLine($"Target temperature set to {targetTemperature}°C");
    }

    public (double min, double max) GetTemperatureRange()
    {
        return (10.0, 30.0);
    }

    public double GetHumidity()
    {
        return humidity;
    }

    public double GetTemperature()
    {
        return currentTemperature;
    }

    public double GetAirQuality()
    {
        return 85.0; // Good air quality
    }

    public void AddSchedule(Schedule schedule)
    {
        schedules.Add(schedule);
        Console.WriteLine($"Schedule added to thermostat '{Name}'");
    }

    public void RemoveSchedule(string scheduleId)
    {
        schedules.RemoveAll(s => s.Id == scheduleId);
    }

    public List<Schedule> GetSchedules()
    {
        return new List<Schedule>(schedules);
    }
}

/// <summary>
/// Security Camera - motion detection, media capture, and security
/// </summary>
public class SecurityCamera : IDevice, ISwitchable, IMotionDetector, IMediaCapture, ISecurityDevice
{
    public string DeviceId { get; }
    public string Name { get; }
    public bool IsOnline { get; private set; }
    public bool IsOn { get; private set; }
    public bool IsArmed { get; private set; }
    
    private int motionSensitivity = 5;
    private bool motionDetected = false;
    private byte[]? lastCapture;
    
    public event EventHandler<MotionEventArgs>? MotionDetected;

    public SecurityCamera(string deviceId, string name)
    {
        DeviceId = deviceId;
        Name = name;
    }

    public void Connect()
    {
        IsOnline = true;
        Console.WriteLine($"Security camera '{Name}' connected");
    }

    public void Disconnect()
    {
        IsOnline = false;
        Console.WriteLine($"Security camera '{Name}' disconnected");
    }

    public DeviceStatus GetStatus()
    {
        return new DeviceStatus
        {
            DeviceId = DeviceId,
            IsOnline = IsOnline,
            Properties = new Dictionary<string, object>
            {
                ["IsOn"] = IsOn,
                ["IsArmed"] = IsArmed,
                ["MotionDetected"] = motionDetected
            }
        };
    }

    public void TurnOn()
    {
        IsOn = true;
        Console.WriteLine($"Camera '{Name}' turned on");
    }

    public void TurnOff()
    {
        IsOn = false;
        Console.WriteLine($"Camera '{Name}' turned off");
    }

    public bool IsMotionDetected()
    {
        return motionDetected;
    }

    public void SetSensitivity(int level)
    {
        motionSensitivity = Math.Clamp(level, 1, 10);
        Console.WriteLine($"Motion sensitivity set to {motionSensitivity}");
    }

    public void TakePhoto()
    {
        Console.WriteLine($"Camera '{Name}' capturing photo");
        lastCapture = new byte[1024]; // Simulated photo data
    }

    public void StartRecording()
    {
        Console.WriteLine($"Camera '{Name}' started recording");
    }

    public void StopRecording()
    {
        Console.WriteLine($"Camera '{Name}' stopped recording");
    }

    public byte[] GetLastCapture()
    {
        return lastCapture ?? Array.Empty<byte>();
    }

    public void Arm()
    {
        IsArmed = true;
        Console.WriteLine($"Camera '{Name}' armed");
    }

    public void Disarm(string code)
    {
        if (code == "1234") // Simple validation
        {
            IsArmed = false;
            Console.WriteLine($"Camera '{Name}' disarmed");
        }
    }

    public void TriggerAlarm()
    {
        Console.WriteLine($"ALARM! Motion detected on camera '{Name}'");
        MotionDetected?.Invoke(this, new MotionEventArgs { Timestamp = DateTime.Now });
    }
}

/// <summary>
/// Smart Speaker - audio playback and basic controls
/// </summary>
public class SmartSpeaker : IDevice, ISwitchable, IAudioPlayer, IAdjustable
{
    public string DeviceId { get; }
    public string Name { get; }
    public bool IsOnline { get; private set; }
    public bool IsOn { get; private set; }
    public int MaxLevel => 100;
    
    private int volume = 50;
    private bool isPlaying = false;

    public SmartSpeaker(string deviceId, string name)
    {
        DeviceId = deviceId;
        Name = name;
    }

    public void Connect()
    {
        IsOnline = true;
        Console.WriteLine($"Smart speaker '{Name}' connected");
    }

    public void Disconnect()
    {
        IsOnline = false;
        Console.WriteLine($"Smart speaker '{Name}' disconnected");
    }

    public DeviceStatus GetStatus()
    {
        return new DeviceStatus
        {
            DeviceId = DeviceId,
            IsOnline = IsOnline,
            Properties = new Dictionary<string, object>
            {
                ["IsOn"] = IsOn,
                ["Volume"] = volume,
                ["IsPlaying"] = isPlaying
            }
        };
    }

    public void TurnOn()
    {
        IsOn = true;
        Console.WriteLine($"Speaker '{Name}' turned on");
    }

    public void TurnOff()
    {
        IsOn = false;
        if (isPlaying)
        {
            StopAudio();
        }
        Console.WriteLine($"Speaker '{Name}' turned off");
    }

    public void PlayAudio(string source)
    {
        isPlaying = true;
        Console.WriteLine($"Speaker '{Name}' playing: {source}");
    }

    public void StopAudio()
    {
        isPlaying = false;
        Console.WriteLine($"Speaker '{Name}' stopped playing");
    }

    public void SetVolume(int volume)
    {
        this.volume = Math.Clamp(volume, 0, MaxLevel);
        Console.WriteLine($"Speaker '{Name}' volume set to {this.volume}");
    }

    public int GetVolume()
    {
        return volume;
    }

    public int GetLevel()
    {
        return volume;
    }

    public void SetLevel(int level)
    {
        SetVolume(level);
    }
}

/// <summary>
/// Smart Door Lock - security focused
/// </summary>
public class SmartDoorLock : IDevice, ISecurityDevice, ISchedulable
{
    public string DeviceId { get; }
    public string Name { get; }
    public bool IsOnline { get; private set; }
    public bool IsArmed { get; private set; }
    
    private bool isLocked = true;
    private readonly List<Schedule> schedules = new List<Schedule>();
    private readonly List<string> accessCodes = new List<string> { "1234", "5678" };

    public SmartDoorLock(string deviceId, string name)
    {
        DeviceId = deviceId;
        Name = name;
    }

    public void Connect()
    {
        IsOnline = true;
        Console.WriteLine($"Smart lock '{Name}' connected");
    }

    public void Disconnect()
    {
        IsOnline = false;
        Console.WriteLine($"Smart lock '{Name}' disconnected");
    }

    public DeviceStatus GetStatus()
    {
        return new DeviceStatus
        {
            DeviceId = DeviceId,
            IsOnline = IsOnline,
            Properties = new Dictionary<string, object>
            {
                ["IsLocked"] = isLocked,
                ["IsArmed"] = IsArmed
            }
        };
    }

    public void Arm()
    {
        IsArmed = true;
        isLocked = true;
        Console.WriteLine($"Door lock '{Name}' armed and locked");
    }

    public void Disarm(string code)
    {
        if (accessCodes.Contains(code))
        {
            IsArmed = false;
            isLocked = false;
            Console.WriteLine($"Door lock '{Name}' disarmed and unlocked");
        }
        else
        {
            Console.WriteLine($"Invalid code for door lock '{Name}'");
        }
    }

    public void TriggerAlarm()
    {
        Console.WriteLine($"SECURITY ALERT! Unauthorized access attempt on '{Name}'");
    }

    public void AddSchedule(Schedule schedule)
    {
        schedules.Add(schedule);
        Console.WriteLine($"Auto-lock schedule added to '{Name}'");
    }

    public void RemoveSchedule(string scheduleId)
    {
        schedules.RemoveAll(s => s.Id == scheduleId);
    }

    public List<Schedule> GetSchedules()
    {
        return new List<Schedule>(schedules);
    }
}

/// <summary>
/// Motion Sensor - simple detection device
/// </summary>
public class MotionSensor : IDevice, IMotionDetector
{
    public string DeviceId { get; }
    public string Name { get; }
    public bool IsOnline { get; private set; }
    
    private int sensitivity = 5;
    private bool motionDetected = false;
    
    public event EventHandler<MotionEventArgs>? MotionDetected;

    public MotionSensor(string deviceId, string name)
    {
        DeviceId = deviceId;
        Name = name;
    }

    public void Connect()
    {
        IsOnline = true;
        Console.WriteLine($"Motion sensor '{Name}' connected");
    }

    public void Disconnect()
    {
        IsOnline = false;
        Console.WriteLine($"Motion sensor '{Name}' disconnected");
    }

    public DeviceStatus GetStatus()
    {
        return new DeviceStatus
        {
            DeviceId = DeviceId,
            IsOnline = IsOnline,
            Properties = new Dictionary<string, object>
            {
                ["MotionDetected"] = motionDetected,
                ["Sensitivity"] = sensitivity
            }
        };
    }

    public bool IsMotionDetected()
    {
        return motionDetected;
    }

    public void SetSensitivity(int level)
    {
        sensitivity = Math.Clamp(level, 1, 10);
        Console.WriteLine($"Sensor '{Name}' sensitivity set to {sensitivity}");
    }

    public void SimulateMotion()
    {
        motionDetected = true;
        Console.WriteLine($"Motion detected by sensor '{Name}'");
        MotionDetected?.Invoke(this, new MotionEventArgs { Timestamp = DateTime.Now });
        
        // Reset after a moment
        Task.Delay(2000).ContinueWith(_ => motionDetected = false);
    }
}

// ========== SMART HOME SERVICES ==========

/// <summary>
/// Automation Service - works with schedulable devices
/// </summary>
public class AutomationService
{
    private readonly List<ISchedulable> schedulableDevices = new List<ISchedulable>();

    public void RegisterDevice(ISchedulable device)
    {
        schedulableDevices.Add(device);
        Console.WriteLine("Device registered for automation");
    }

    public void CreateRoutine(string name, TimeSpan time, Action<ISchedulable> action)
    {
        var schedule = new Schedule
        {
            Id = Guid.NewGuid().ToString(),
            Name = name,
            Time = time,
            IsActive = true
        };

        foreach (var device in schedulableDevices)
        {
            device.AddSchedule(schedule);
        }

        Console.WriteLine($"Automation routine '{name}' created");
    }
}

/// <summary>
/// Security Service - manages security devices
/// </summary>
public class SecurityService
{
    private readonly List<ISecurityDevice> securityDevices = new List<ISecurityDevice>();
    private readonly List<IMotionDetector> motionDetectors = new List<IMotionDetector>();

    public void RegisterSecurityDevice(ISecurityDevice device)
    {
        securityDevices.Add(device);
        Console.WriteLine("Security device registered");
    }

    public void RegisterMotionDetector(IMotionDetector detector)
    {
        motionDetectors.Add(detector);
        detector.MotionDetected += OnMotionDetected;
        Console.WriteLine("Motion detector registered");
    }

    public void ArmAllDevices()
    {
        foreach (var device in securityDevices)
        {
            device.Arm();
        }
        Console.WriteLine("All security devices armed");
    }

    public void DisarmAllDevices(string code)
    {
        foreach (var device in securityDevices)
        {
            device.Disarm(code);
        }
    }

    private void OnMotionDetected(object? sender, MotionEventArgs e)
    {
        Console.WriteLine($"ALERT: Motion detected at {e.Timestamp}");
        
        // Trigger alarms on all armed security devices
        foreach (var device in securityDevices.Where(d => d.IsArmed))
        {
            device.TriggerAlarm();
        }
    }
}

/// <summary>
/// Lighting Service - controls lights
/// </summary>
public class LightingService
{
    private readonly List<ISwitchable> lights = new List<ISwitchable>();
    private readonly List<IAdjustable> dimmableLights = new List<IAdjustable>();
    private readonly List<IColorChangeable> colorLights = new List<IColorChangeable>();

    public void RegisterLight(ISwitchable light)
    {
        lights.Add(light);
        
        if (light is IAdjustable dimmable)
            dimmableLights.Add(dimmable);
        
        if (light is IColorChangeable colorLight)
            colorLights.Add(colorLight);
        
        Console.WriteLine("Light registered");
    }

    public void TurnAllLightsOn()
    {
        foreach (var light in lights)
        {
            light.TurnOn();
        }
    }

    public void TurnAllLightsOff()
    {
        foreach (var light in lights)
        {
            light.TurnOff();
        }
    }

    public void SetMoodLighting(string mood)
    {
        Console.WriteLine($"Setting mood: {mood}");
        
        switch (mood.ToLower())
        {
            case "romantic":
                foreach (var light in dimmableLights)
                    light.SetLevel(30);
                foreach (var light in colorLights)
                    light.SetColor(Color.Red);
                break;
                
            case "party":
                foreach (var light in dimmableLights)
                    light.SetLevel(100);
                foreach (var light in colorLights)
                    light.SetColor(Color.Blue);
                break;
                
            case "relax":
                foreach (var light in dimmableLights)
                    light.SetLevel(50);
                foreach (var light in colorLights)
                    light.SetColor(Color.Yellow);
                break;
        }
    }
}

// ========== SUPPORTING CLASSES ==========

public class DeviceStatus
{
    public string DeviceId { get; set; } = "";
    public bool IsOnline { get; set; }
    public Dictionary<string, object> Properties { get; set; } = new Dictionary<string, object>();
}

public class Schedule
{
    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
    public TimeSpan Time { get; set; }
    public bool IsActive { get; set; }
}

public class MotionEventArgs : EventArgs
{
    public DateTime Timestamp { get; set; }
}

public enum Color
{
    White,
    Red,
    Green,
    Blue,
    Yellow,
    Purple,
    Orange
}