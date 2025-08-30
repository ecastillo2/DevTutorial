using InterfaceSegregation.BadExamples;
using InterfaceSegregation.GoodExamples;
using InterfaceSegregation.PracticalExample;

Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║         INTERFACE SEGREGATION PRINCIPLE (ISP)                          ║");
Console.WriteLine("║                    S.O.L.I.D Principles - Part 4                      ║");
Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
Console.WriteLine();

// Display ISP concept
Console.WriteLine("INTERFACE SEGREGATION PRINCIPLE:");
Console.WriteLine("════════════════════════════════\n");

Console.WriteLine("┌─────────────────────────────────────────────────────────────────────┐");
Console.WriteLine("│                                                                     │");
Console.WriteLine("│  \"Clients should not be forced to depend on interfaces             │");
Console.WriteLine("│   they do not use\"                                                 │");
Console.WriteLine("│                                    - Robert C. Martin               │");
Console.WriteLine("│                                                                     │");
Console.WriteLine("│  In other words:                                                    │");
Console.WriteLine("│  • Make interfaces small and focused                               │");
Console.WriteLine("│  • Split large interfaces into smaller ones                        │");
Console.WriteLine("│  • Classes implement only what they need                           │");
Console.WriteLine("│                                                                     │");
Console.WriteLine("└─────────────────────────────────────────────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("WHY ISP MATTERS:");
Console.WriteLine("════════════════\n");

Console.WriteLine("┌────────────────────────────────┐     ┌────────────────────────────────┐");
Console.WriteLine("│      WITHOUT ISP (Bad)         │     │       WITH ISP (Good)          │");
Console.WriteLine("├────────────────────────────────┤     ├────────────────────────────────┤");
Console.WriteLine("│ • Fat interfaces               │     │ • Focused interfaces           │");
Console.WriteLine("│ • Unused method implementations│     │ • Implement only what's needed │");
Console.WriteLine("│ • NotImplementedException      │     │ • No dummy implementations     │");
Console.WriteLine("│ • High coupling                │     │ • Low coupling                 │");
Console.WriteLine("│ • Hard to understand           │     │ • Clear responsibilities       │");
Console.WriteLine("│ • Difficult to test            │     │ • Easy to test                 │");
Console.WriteLine("└────────────────────────────────┘     └────────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("FAT INTERFACE PROBLEM:");
Console.WriteLine("══════════════════════\n");

Console.WriteLine("┌─────────────────────────────────────┐");
Console.WriteLine("│           IWorker (Bad)             │");
Console.WriteLine("├─────────────────────────────────────┤");
Console.WriteLine("│ • Work()                            │");
Console.WriteLine("│ • TakeBreak()                       │");
Console.WriteLine("│ • CalculateSalary()                 │");
Console.WriteLine("│ • ManageTeam()                      │");
Console.WriteLine("│ • WriteCode()                       │");
Console.WriteLine("│ • ConductReview()                   │");
Console.WriteLine("│ • FileReports()                     │");
Console.WriteLine("├─────────────────────────────────────┤");
Console.WriteLine("│ ❌ Developer: Doesn't manage teams  │");
Console.WriteLine("│ ❌ Manager: Doesn't write code      │");
Console.WriteLine("│ ❌ Robot: Doesn't take breaks       │");
Console.WriteLine("└─────────────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("SEGREGATED INTERFACES SOLUTION:");
Console.WriteLine("═══════════════════════════════\n");

Console.WriteLine("    ┌──────────┐  ┌──────────┐  ┌────────────┐  ┌─────────────┐");
Console.WriteLine("    │IWorkable │  │IBreakable│  │IManageable │  │ITechnical   │");
Console.WriteLine("    └────┬─────┘  └────┬─────┘  └─────┬──────┘  └──────┬──────┘");
Console.WriteLine("         │             │               │                 │");
Console.WriteLine("    ┌────┴─────────────┴───────────────┴─────────────────┴────┐");
Console.WriteLine("    │                                                          │");
Console.WriteLine("    │  Developer: IWorkable, IBreakable, ITechnical ✓         │");
Console.WriteLine("    │  Manager: IWorkable, IBreakable, IManageable ✓          │");
Console.WriteLine("    │  Robot: IWorkable, ITechnical ✓                         │");
Console.WriteLine("    │                                                          │");
Console.WriteLine("    │  Each class implements only what it needs!              │");
Console.WriteLine("    └──────────────────────────────────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("\n══════════════════════════════════════════════════════════════════");
Console.WriteLine("                    ISP IN ACTION - EXAMPLES");
Console.WriteLine("══════════════════════════════════════════════════════════════════\n");

// DEMONSTRATION 1: Bad Worker Example
Console.WriteLine("1. BAD EXAMPLE - Fat Worker Interface:");
Console.WriteLine("──────────────────────────────────────");

var developer_bad = new Developer_Bad();
var manager_bad = new Manager_Bad();
var robot_bad = new Robot_Bad();

// Developer works fine with technical methods
developer_bad.WriteCode();
developer_bad.FixBugs();

// But fails with management methods
try
{
    developer_bad.ManageTeam();
}
catch (NotImplementedException ex)
{
    Console.WriteLine($"❌ ISP VIOLATION: {ex.Message}");
}

// Manager fails with technical methods
try
{
    manager_bad.WriteCode();
}
catch (NotImplementedException ex)
{
    Console.WriteLine($"❌ ISP VIOLATION: {ex.Message}");
}

// Robot fails with human-specific methods
try
{
    robot_bad.TakeBreak();
}
catch (NotImplementedException ex)
{
    Console.WriteLine($"❌ ISP VIOLATION: {ex.Message}");
}

// DEMONSTRATION 2: Good Worker Design
Console.WriteLine("\n\n2. GOOD EXAMPLE - Segregated Worker Interfaces:");
Console.WriteLine("────────────────────────────────────────────────");

var developer = new Developer();
var manager = new Manager();
var robot = new Robot();
var intern = new Intern();

// Each type implements only what makes sense
Console.WriteLine("\nDeveloper capabilities:");
ProcessWorkable(developer);
ProcessBreakable(developer);
ProcessTechnical(developer);

Console.WriteLine("\nManager capabilities:");
ProcessWorkable(manager);
ProcessBreakable(manager);
ProcessManageable(manager);

Console.WriteLine("\nRobot capabilities:");
ProcessWorkable(robot);
ProcessTechnical(robot);
// ProcessBreakable(robot); // Compile error - robots don't implement IBreakable

Console.WriteLine("\nIntern capabilities:");
ProcessWorkable(intern);
ProcessBreakable(intern);
ProcessAdministrative(intern);

void ProcessWorkable(IWorkable worker)
{
    worker.Work();
}

void ProcessBreakable(IBreakable worker)
{
    worker.TakeBreak();
}

void ProcessTechnical(ITechnical worker)
{
    worker.WriteCode();
    worker.FixBugs();
}

void ProcessManageable(IManageable manager)
{
    manager.ManageTeam();
    manager.ConductPerformanceReview();
}

void ProcessAdministrative(IAdministrative admin)
{
    admin.FileReports();
    admin.AttendMeetings();
}

// DEMONSTRATION 3: Bad Printer Example
Console.WriteLine("\n\n3. BAD EXAMPLE - All-in-One Printer Interface:");
Console.WriteLine("───────────────────────────────────────────────");

var simplePrinter_bad = new SimplePrinter_Bad();

// Simple printer can only print
simplePrinter_bad.Print("Document.pdf");

// But forced to implement features it doesn't have
try
{
    simplePrinter_bad.Scan("Document");
}
catch (NotSupportedException ex)
{
    Console.WriteLine($"❌ ISP VIOLATION: {ex.Message}");
}

try
{
    simplePrinter_bad.PrintDuplex("Document");
}
catch (NotSupportedException ex)
{
    Console.WriteLine($"❌ ISP VIOLATION: {ex.Message}");
}

// DEMONSTRATION 4: Good Printer Design
Console.WriteLine("\n\n4. GOOD EXAMPLE - Segregated Printer Interfaces:");
Console.WriteLine("─────────────────────────────────────────────────");

var simplePrinter = new SimplePrinter();
var multifunctionPrinter = new MultifunctionPrinter();
var professionalPrinter = new ProfessionalPrinter();

Console.WriteLine("\nSimple Printer (basic printing only):");
PrintDocument(simplePrinter, "Report.pdf");

Console.WriteLine("\nMultifunction Printer (multiple capabilities):");
PrintDocument(multifunctionPrinter, "Report.pdf");
ScanDocument(multifunctionPrinter, "Contract.pdf");
SendFax(multifunctionPrinter, "Invoice.pdf", "555-1234");
EmailDocument(multifunctionPrinter, "Summary.pdf", "boss@company.com");

Console.WriteLine("\nProfessional Printer (advanced printing):");
PrintDocument(professionalPrinter, "Brochure.pdf");
PrintInColor(professionalPrinter, "Poster.pdf");
PrintDuplex(professionalPrinter, "Manual.pdf");
StapleDocument(professionalPrinter, "Report.pdf");

void PrintDocument(IPrinter printer, string document)
{
    printer.Print(document);
}

void ScanDocument(IScanner scanner, string document)
{
    scanner.Scan(document);
}

void SendFax(IFax fax, string document, string number)
{
    fax.Fax(document, number);
}

void PrintInColor(IColorPrinter printer, string document)
{
    printer.PrintColor(document);
}

void PrintDuplex(IDuplexPrinter printer, string document)
{
    printer.PrintDuplex(document);
}

void StapleDocument(IStapler stapler, string document)
{
    stapler.Staple(document);
}

void EmailDocument(INetworkPrinter printer, string document, string recipient)
{
    printer.Email(document, recipient);
}

// DEMONSTRATION 5: Media Player Example
Console.WriteLine("\n\n5. MEDIA PLAYER - Segregated Interfaces:");
Console.WriteLine("─────────────────────────────────────────");

var basicAudioPlayer = new BasicAudioPlayer();
var streamingPlayer = new StreamingAudioPlayer();
var professionalSuite = new ProfessionalMediaSuite();

Console.WriteLine("\nBasic Audio Player:");
PlayAudio(basicAudioPlayer, "song.mp3");

Console.WriteLine("\nStreaming Audio Player:");
PlayAudio(streamingPlayer, "podcast.mp3");
StreamContent(streamingPlayer, "https://radio.station.com");
ManagePlaylist(streamingPlayer, "My Favorites");

Console.WriteLine("\nProfessional Media Suite:");
PlayAudio(professionalSuite, "music.mp3");
PlayVideo(professionalSuite, "movie.mp4");
StreamContent(professionalSuite, "https://streaming.service.com");
RecordAudio(professionalSuite);
RecordVideo(professionalSuite);

void PlayAudio(InterfaceSegregation.GoodExamples.IAudioPlayer player, string file)
{
    player.PlayAudio(file);
    player.PauseAudio();
    player.StopAudio();
}

void PlayVideo(IVideoPlayer player, string file)
{
    player.PlayVideo(file);
}

void StreamContent(IMediaStreamer streamer, string url)
{
    streamer.StreamOnline(url);
}

void RecordAudio(IAudioRecorder recorder)
{
    recorder.RecordAudio();
    recorder.StopRecording();
}

void RecordVideo(IVideoRecorder recorder)
{
    recorder.RecordVideo();
    recorder.StopRecording();
}

void ManagePlaylist(IPlaylistManager manager, string playlistName)
{
    manager.CreatePlaylist(playlistName);
    manager.AddToPlaylist("track1.mp3");
    manager.AddToPlaylist("track2.mp3");
}

// DEMONSTRATION 6: Vehicle Example
Console.WriteLine("\n\n6. VEHICLE SYSTEM - Proper Interface Design:");
Console.WriteLine("─────────────────────────────────────────────");

var gasCar = new GasCar();
var electricCar = new ElectricCar();
var airplane = new Airplane();
var bicycle = new Bicycle();

Console.WriteLine("\nGas Car:");
DriveVehicle(gasCar);
StartEngine(gasCar);
RefuelVehicle(gasCar);

Console.WriteLine("\nElectric Car:");
DriveVehicle(electricCar);
ChargeVehicle(electricCar);
UseAutopilot(electricCar);

Console.WriteLine("\nAirplane:");
DriveVehicle(airplane);
StartEngine(airplane);
FlyVehicle(airplane);

Console.WriteLine("\nBicycle (human-powered):");
DriveVehicle(bicycle);
// No engine, no fuel, no charging - just pedaling!

void DriveVehicle(IVehicle vehicle)
{
    vehicle.Accelerate();
    vehicle.Brake();
}

void StartEngine(IEngine engine)
{
    engine.StartEngine();
    engine.StopEngine();
}

void RefuelVehicle(IFuelPowered vehicle)
{
    Console.WriteLine($"Fuel level: {vehicle.GetFuelLevel()}%");
    vehicle.RefuelGas();
}

void ChargeVehicle(IElectric vehicle)
{
    Console.WriteLine($"Battery level: {vehicle.GetBatteryLevel()}%");
    vehicle.ChargeBattery();
}

void FlyVehicle(IFlyable vehicle)
{
    vehicle.TakeOff();
    vehicle.Fly();
    vehicle.Land();
}

void UseAutopilot(IAutonomous vehicle)
{
    vehicle.EngageAutopilot();
    vehicle.DisengageAutopilot();
}

// DEMONSTRATION 7: Restaurant Example
Console.WriteLine("\n\n7. RESTAURANT SYSTEM - Role-Based Interfaces:");
Console.WriteLine("──────────────────────────────────────────────");

var chef = new Chef();
var waiter = new Waiter();
var restaurantManager = new RestaurantManager();
var dishwasher = new Dishwasher();

Console.WriteLine("\nChef responsibilities:");
CookMeal(chef, "Pasta Carbonara");

Console.WriteLine("\nWaiter responsibilities:");
ServeCustomers(waiter, 5);
ProcessBill(waiter, 45.50m);

Console.WriteLine("\nManager responsibilities:");
ManageRestaurant(restaurantManager);

Console.WriteLine("\nDishwasher responsibilities:");
CleanUp(dishwasher);

void CookMeal(ICook cook, string dish)
{
    cook.CookFood(dish);
    cook.TasteFood();
    cook.PrepareDessert("Tiramisu");
}

void ServeCustomers(IServer server, int tableNumber)
{
    server.TakeOrder(tableNumber);
    server.ServeFood(tableNumber);
    server.ClearTable(tableNumber);
}

void ProcessBill(ICashier cashier, decimal amount)
{
    cashier.ProcessPayment(amount);
    cashier.GiveChange(10.50m);
    cashier.PrintReceipt();
}

void ManageRestaurant(IManager manager)
{
    manager.HireEmployee("New Chef");
    manager.CreateMenu();
    manager.ReviewPerformance();
}

void CleanUp(IDishwasher washer)
{
    washer.WashDishes();
    washer.OrganizeKitchen();
}

// DEMONSTRATION 8: Practical Smart Home Example
Console.WriteLine("\n\n8. PRACTICAL EXAMPLE - Smart Home System:");
Console.WriteLine("══════════════════════════════════════════");

// Create devices
var livingRoomLight = new SmartLight("light1", "Living Room Light");
var bedroomLight = new SmartLight("light2", "Bedroom Light");
var thermostat = new SmartThermostat("thermo1", "Main Thermostat");
var frontCamera = new SecurityCamera("cam1", "Front Door Camera");
var speaker = new SmartSpeaker("speaker1", "Living Room Speaker");
var doorLock = new SmartDoorLock("lock1", "Front Door");
var motionSensor = new MotionSensor("motion1", "Hallway Sensor");

// Connect all devices
var devices = new List<IDevice> { livingRoomLight, bedroomLight, thermostat, 
    frontCamera, speaker, doorLock, motionSensor };

foreach (var device in devices)
{
    device.Connect();
}

// Set up services
var lightingService = new LightingService();
var securityService = new SecurityService();
var automationService = new AutomationService();

// Register devices with appropriate services
Console.WriteLine("\nRegistering devices with services:");
lightingService.RegisterLight(livingRoomLight);
lightingService.RegisterLight(bedroomLight);

securityService.RegisterSecurityDevice(frontCamera);
securityService.RegisterSecurityDevice(doorLock);
securityService.RegisterMotionDetector(frontCamera);
securityService.RegisterMotionDetector(motionSensor);

automationService.RegisterDevice(livingRoomLight);
automationService.RegisterDevice(thermostat);
automationService.RegisterDevice(doorLock);

// Demonstrate lighting control
Console.WriteLine("\n\nLighting Control:");
Console.WriteLine("─────────────────");
lightingService.TurnAllLightsOn();
lightingService.SetMoodLighting("romantic");

// Demonstrate security features
Console.WriteLine("\n\nSecurity System:");
Console.WriteLine("────────────────");
securityService.ArmAllDevices();
motionSensor.SimulateMotion(); // This will trigger alarms

// Demonstrate automation
Console.WriteLine("\n\nHome Automation:");
Console.WriteLine("────────────────");
automationService.CreateRoutine("Good Night", TimeSpan.FromHours(22), device =>
{
    if (device is ISwitchable switchable)
        switchable.TurnOff();
});

// Demonstrate device-specific features
Console.WriteLine("\n\nDevice-Specific Features:");
Console.WriteLine("─────────────────────────");

// Temperature control (only thermostat)
if (thermostat is ITemperatureControl tempControl)
{
    Console.WriteLine($"Current temperature: {tempControl.GetCurrentTemperature()}°C");
    tempControl.SetTargetTemperature(23.0);
}

// Audio playback (only speaker)
if (speaker is InterfaceSegregation.PracticalExample.IAudioPlayer audio)
{
    audio.PlayAudio("Relaxing Music");
    audio.SetVolume(60);
}

// Color changing (only smart lights)
foreach (var device in devices.OfType<IColorChangeable>())
{
    device.SetColor(Color.Blue);
}

// DEMONSTRATION 9: Interface Segregation Benefits
Console.WriteLine("\n\n9. BENEFITS OF ISP:");
Console.WriteLine("════════════════════");

Console.WriteLine("\n┌────────────────────────────────────────────────────────────┐");
Console.WriteLine("│              MAINTENANCE SCENARIO                          │");
Console.WriteLine("├────────────────────────────────────────────────────────────┤");
Console.WriteLine("│ Requirement: Add voice control to smart devices            │");
Console.WriteLine("│                                                            │");
Console.WriteLine("│ Without ISP:                                               │");
Console.WriteLine("│ • Add voice methods to fat IDevice interface              │");
Console.WriteLine("│ • All devices must implement (even if not supported)      │");
Console.WriteLine("│ • Lots of NotImplementedException                         │");
Console.WriteLine("│ • Breaks existing device implementations                  │");
Console.WriteLine("│                                                            │");
Console.WriteLine("│ With ISP:                                                  │");
Console.WriteLine("│ • Create new IVoiceControllable interface                 │");
Console.WriteLine("│ • Only voice-capable devices implement it                 │");
Console.WriteLine("│ • Existing devices unchanged                              │");
Console.WriteLine("│ • Clean, optional capability                              │");
Console.WriteLine("└────────────────────────────────────────────────────────────┘");

Console.WriteLine("\n\nKEY TAKEAWAYS:");
Console.WriteLine("═══════════════");

Console.WriteLine("┌─────────────────────────────────────────────────────────────────────┐");
Console.WriteLine("│ 1. SMALL INTERFACES: Keep interfaces focused on one concern        │");
Console.WriteLine("│ 2. CLIENT-SPECIFIC: Design interfaces for specific client needs    │");
Console.WriteLine("│ 3. NO FORCING: Don't force implementations of unused methods       │");
Console.WriteLine("│ 4. COMPOSITION: Combine small interfaces as needed                 │");
Console.WriteLine("│ 5. ROLE-BASED: Think about roles and capabilities                  │");
Console.WriteLine("│ 6. FLEXIBILITY: Easy to add new interfaces without breaking code   │");
Console.WriteLine("└─────────────────────────────────────────────────────────────────────┘");

Console.WriteLine("\n╔══════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║   ISP: Many specific interfaces > One general interface! 🎯      ║");
Console.WriteLine("╚══════════════════════════════════════════════════════════════════╝");