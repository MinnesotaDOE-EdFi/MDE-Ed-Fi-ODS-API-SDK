# EdFi.OdsApi.Sdk.Models.All.EdFiStudentHomelessProgramAssociation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**BeginDate** | **DateTime?** | The month, day, and year on which the Student first received services. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**ProgramReference** | [**EdFiProgramReference**](EdFiProgramReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**AwaitingFosterCare** | **bool?** | State defined definition for awaiting foster care. | [optional] 
**EndDate** | **DateTime?** | The month, day, and year on which the Student exited the Program or stopped receiving services. | [optional] 
**HomelessPrimaryNighttimeResidenceDescriptor** | **string** | The primary nighttime residence of the student at the time the student is identified as homeless. | [optional] 
**HomelessProgramServices** | [**List&lt;EdFiStudentHomelessProgramAssociationHomelessProgramService&gt;**](EdFiStudentHomelessProgramAssociationHomelessProgramService.md) | An unordered collection of studentHomelessProgramAssociationHomelessProgramServices. Indicates the service(s) being provided to the Student by the Homeless Program. | [optional] 
**HomelessUnaccompaniedYouth** | **bool?** | A homeless unaccompanied youth is a youth who is not in the physical custody of a parent or guardian and who fits the McKinney-Vento definition of homeless. Students must be both unaccompanied and homeless to be included as an unaccompanied homeless youth. | [optional] 
**ReasonExitedDescriptor** | **string** | The reason the child left the Program within a school or district. | [optional] 
**ServedOutsideOfRegularSession** | **bool?** | Indicates whether the Student received services during the summer session or between sessions. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

