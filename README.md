# DvlaSearch-CSharp
A helper library for https://api.vehicle-search.co.uk/

_Please note; I am not associated with or maintain the api this helper uses._ 

## Driver Licence Check

### Usage

```c#
var apiKey = "example123";
var helper = new DvlaSearchHelper(apiKey);

var licenceNumber = "...";
var niNumber = "...";
var postCode = "...";
 
var licenceResult = helper.GetDriverLicence(licenceNumber, niNumber, postCode);

switch (licenceResult) {
    case Error error:
        Console.WriteLine(error.ErrorMessage);
        break;
        
    case NotFound:
        Console.WriteLine("Licence was not found");
        break;
        
    case Success<DriverLicenceResult> success:
        var licence = success.Content;
        Console.WriteLine($"{licence.Name} has {licence.PenaltyPoints} point(s)");
        break;
}

// or using pattern matching

var licence = (licenceResult) switch {
    Success<DriverLicenceResult> success => success.Content,
    Error error => throw new Exception(error.ErrorMessage),
    _ => null,
};

```

## API Coverage

Current list of endpoints and their respective support status

### Account Tools
Account endpoints
- ❌ `Account Info` _Account Lookup_

### Driver Tools
Tools relating to drivers
- ✅ `Driver Licence Info` _Information for given licence number_

### Search Tools
Search endpoints **(will expend credits)**

- ❌ `Battery` _Contains the configuration details of each battery_
- ❌ `Car Spec` _Search DVLA from Licence plate for specifications of the vehicle._
- ❌ `Dvla` Search _Search DVLA from Licence plate_
- ❌ `Insurance` _Returns information relevant for insurance_
- ❌ `Mot History` _MOT History from licence plate_
- ❌ `Tyre Search` _Tyre recommendations based on licence plate_
- ❌ `V5C Validate` _Validation takes a vehicle registration and V5C number_
- ❌ `Valuation` _Based on a number of factors, such as the MOT history (for mileage and condition), the previous number of owners and calculations from our partnership with insurance companies._
- ❌ `Vehicle Image` _Returns a representative image of the vehicle_
- ❌ `VIN Search` _Search DVLA from VIN_

### Account Records
Account statistic endpoints

- ❌ `Search Count` _Search Count_
- ❌ `Search History` _Search Count_

### Additional Services
These endpoints require an additional purchase to be accessible
- ❌ `Postcode To Address` _Returns address at given postcode_
