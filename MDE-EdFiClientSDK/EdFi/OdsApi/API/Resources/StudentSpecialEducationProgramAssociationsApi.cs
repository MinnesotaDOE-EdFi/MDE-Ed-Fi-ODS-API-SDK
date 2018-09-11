using System;
using System.Collections.Generic;
using System.Linq;
using EdFi.OdsApi.Sdk;
using EdFi.OdsApi.Models.Resources;
using RestSharp;
  
namespace EdFi.OdsApi.Api.Resources 
{
    public class StudentSpecialEducationProgramAssociationsApi 
    {
        private readonly IRestClient client;

        public StudentSpecialEducationProgramAssociationsApi(IRestClient client)
        {
            this.client = client;
        }
      
        /// <summary>
        /// Retrieves resources based with paging capabilities (using the &quot;Get All&quot; pattern). This GET operation provides access to resources using the &quot;Get All&quot; pattern. In this version of the API there is support for paging.
        /// </summary>
        /// <param name="offset">Indicates how many items should be skipped before returning results.</param>
        /// <param name="limit">Indicates the maximum number of items that should be returned in the results (defaults to 25).</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse<List<StudentSpecialEducationProgramAssociation>> GetStudentSpecialEducationProgramAssociationsAll(int? offset= null, int? limit= null) 
        {
            var request = new RestRequest("/studentSpecialEducationProgramAssociations", Method.GET);
            request.RequestFormat = DataFormat.Json;

            if (offset != null)
                request.AddParameter("offset", offset);
            if (limit != null)
                request.AddParameter("limit", limit);
            request.AddHeader("Accept", "application/json");
            var response = client.Execute<List<StudentSpecialEducationProgramAssociation>>(request);

            return response;
        }
        /// <summary>
        /// Retrieves resources matching values of an example resource (using the &quot;Get By Example&quot; pattern). This GET operation provides access to resources using the &quot;Get by Example&quot; search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).
        /// </summary>
        /// <param name="offset">Indicates how many items should be skipped before returning results.</param>
        /// <param name="limit">Indicates the maximum number of items that should be returned in the results (defaults to 25).</param>
        /// <param name="educationOrganizationId">The education organization where the student is participating in or receiving the program services.</param>
        /// <param name="programType">A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.</param>
        /// <param name="programName">The formal name of the program of instruction, training, services or benefits available through federal, state, or local agencies.</param>
        /// <param name="programEducationOrganizationId">The education organization where the student is participating in or receiving the program services.</param>
        /// <param name="beginDate">The month, day, and year on which the Student first received services.</param>
        /// <param name="specialEducationSettingDescriptor">A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.</param>
        /// <param name="ideaEligibility">Indicator of the eligibility of the student to receive special education services according to the Individuals with Disabilities Education Act (IDEA).</param>
        /// <param name="specialEducationHoursPerWeek">The number of hours per week for special education instruction and therapy.</param>
        /// <param name="schoolHoursPerWeek">Indicate the total number of hours of instructional time per week for the school that the student attends.</param>
        /// <param name="multiplyDisabled">Indicates whether the Student receiving special education and related services has been designated as multiply disabled by the admission, review, and dismissal committee as aligned with federal requirements.</param>
        /// <param name="medicallyFragile">Indicates whether the Student receiving special education and related services is: 1) in the age range of birth to 22 years, and 2) has a serious, ongoing illness or a chronic condition that has lasted or is anticipated to last at least 12 or more months or has required at least one month of hospitalization, and that requires daily, ongoing medical treatments and monitoring by appropriately trained personnel which may include parents or other family members, and 3) requires the routine use of medical device or of assistive technology to compensate for the loss of usefulness of a body function needed to participate in activities of daily living, and 4) lives with ongoing threat to his or her continued well-being. Aligns with federal requirements.</param>
        /// <param name="lastEvaluationDate">The date of the last special education evaluation.</param>
        /// <param name="iepReviewDate">The date of the last IEP review.</param>
        /// <param name="iepBeginDate">The effective date of the most recent IEP.</param>
        /// <param name="iepEndDate">The end date of the most recent IEP.</param>
        /// <param name="studentUniqueId">A unique alphanumeric code assigned to a student.</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse<List<StudentSpecialEducationProgramAssociation>> GetStudentSpecialEducationProgramAssociationsByExample(int? offset= null, int? limit= null, int? educationOrganizationId= null, string programType= null, string programName= null, int? programEducationOrganizationId= null, DateTime? beginDate= null, string specialEducationSettingDescriptor= null, bool? ideaEligibility= null, double? specialEducationHoursPerWeek= null, double? schoolHoursPerWeek= null, bool? multiplyDisabled= null, bool? medicallyFragile= null, DateTime? lastEvaluationDate= null, DateTime? iepReviewDate= null, DateTime? iepBeginDate= null, DateTime? iepEndDate= null, string studentUniqueId= null) 
        {
            var request = new RestRequest("/studentSpecialEducationProgramAssociations", Method.GET);
            request.RequestFormat = DataFormat.Json;

            if (offset != null)
                request.AddParameter("offset", offset);
            if (limit != null)
                request.AddParameter("limit", limit);
            if (educationOrganizationId != null)
                request.AddParameter("educationOrganizationId", educationOrganizationId);
            if (programType != null)
                request.AddParameter("programType", programType);
            if (programName != null)
                request.AddParameter("programName", programName);
            if (programEducationOrganizationId != null)
                request.AddParameter("programEducationOrganizationId", programEducationOrganizationId);
            if (beginDate != null)
                request.AddParameter("beginDate", beginDate);
            if (specialEducationSettingDescriptor != null)
                request.AddParameter("specialEducationSettingDescriptor", specialEducationSettingDescriptor);
            if (ideaEligibility != null)
                request.AddParameter("ideaEligibility", ideaEligibility);
            if (specialEducationHoursPerWeek != null)
                request.AddParameter("specialEducationHoursPerWeek", specialEducationHoursPerWeek);
            if (schoolHoursPerWeek != null)
                request.AddParameter("schoolHoursPerWeek", schoolHoursPerWeek);
            if (multiplyDisabled != null)
                request.AddParameter("multiplyDisabled", multiplyDisabled);
            if (medicallyFragile != null)
                request.AddParameter("medicallyFragile", medicallyFragile);
            if (lastEvaluationDate != null)
                request.AddParameter("lastEvaluationDate", lastEvaluationDate);
            if (iepReviewDate != null)
                request.AddParameter("iepReviewDate", iepReviewDate);
            if (iepBeginDate != null)
                request.AddParameter("iepBeginDate", iepBeginDate);
            if (iepEndDate != null)
                request.AddParameter("iepEndDate", iepEndDate);
            if (studentUniqueId != null)
                request.AddParameter("studentUniqueId", studentUniqueId);
            request.AddHeader("Accept", "application/json");
            var response = client.Execute<List<StudentSpecialEducationProgramAssociation>>(request);

            return response;
        }
        /// <summary>
        /// Retrieves a specific resource using the values of the resource's natural key (using the &quot;Get By Key&quot; pattern). This GET operation provides access to resources using the &quot;Get by Key&quot; search pattern. The values of the natural key of the resource must be fully specified, and the service will return the matching result (if it exists).
        /// </summary>
        /// <param name="beginDate">The month, day, and year on which the Student first received services.</param>
        /// <param name="educationOrganizationId">The education organization where the student is participating in or receiving the program services.</param>
        /// <param name="programEducationOrganizationId">The education organization where the student is participating in or receiving the program services.</param>
        /// <param name="programName">The formal name of the program of instruction, training, services or benefits available through federal, state, or local agencies.</param>
        /// <param name="programType">A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.</param>
        /// <param name="studentUniqueId">A unique alphanumeric code assigned to a student.</param>
        /// <param name="IfNoneMatch">The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource.</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse<StudentSpecialEducationProgramAssociation> GetStudentSpecialEducationProgramAssociationByKey(DateTime? beginDate, int? educationOrganizationId, int? programEducationOrganizationId, string programName, string programType, string studentUniqueId, string IfNoneMatch= null) 
        {
            var request = new RestRequest("/studentSpecialEducationProgramAssociations", Method.GET);
            request.RequestFormat = DataFormat.Json;

            // verify required params are set
            if (beginDate == null || educationOrganizationId == null || programEducationOrganizationId == null || programName == null || programType == null || studentUniqueId == null ) 
               throw new ArgumentException("API method call is missing required parameters");
            if (beginDate != null)
                request.AddParameter("beginDate", beginDate);
            if (educationOrganizationId != null)
                request.AddParameter("educationOrganizationId", educationOrganizationId);
            if (programEducationOrganizationId != null)
                request.AddParameter("programEducationOrganizationId", programEducationOrganizationId);
            if (programName != null)
                request.AddParameter("programName", programName);
            if (programType != null)
                request.AddParameter("programType", programType);
            if (studentUniqueId != null)
                request.AddParameter("studentUniqueId", studentUniqueId);
            request.AddHeader("If-None-Match", IfNoneMatch);
            request.AddHeader("Accept", "application/json");
            var response = client.Execute<StudentSpecialEducationProgramAssociation>(request);

            return response;
        }
        /// <summary>
        /// Creates or updates resources based on the natural key values of the supplied resource. The POST operation can be used to create or update resources. In database terms, this is often referred to as an &quot;upsert&quot; operation (insert + update).  Clients should NOT include the resource &quot;id&quot; in the JSON body because it will result in an error (you must use a PUT operation to update a resource by &quot;id&quot;). The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately.
        /// </summary>
        /// <param name="body">The JSON representation of the &quot;studentSpecialEducationProgramAssociation&quot; resource to be created or updated.</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse PostStudentSpecialEducationProgramAssociations(StudentSpecialEducationProgramAssociation body) 
        {
            var request = new RestRequest("/studentSpecialEducationProgramAssociations", Method.POST);
            request.RequestFormat = DataFormat.Json;

            // verify required params are set
            if (body == null ) 
               throw new ArgumentException("API method call is missing required parameters");
            request.AddBody(body);
            request.Parameters.First(param => param.Type == ParameterType.RequestBody).Name = "application/json";
            var response = client.Execute(request);

            var location = response.Headers.FirstOrDefault(x => x.Name == "Location");

            if (location != null && !string.IsNullOrWhiteSpace(location.Value.ToString()))
                body.id = location.Value.ToString().Split('/').Last();
            return response;
        }
        /// <summary>
        /// Retrieves a specific resource using the resource's identifier (using the &quot;Get By Id&quot; pattern). This GET operation retrieves a resource by the specified resource identifier.
        /// </summary>
        /// <param name="id">A resource identifier specifying the resource to be retrieved.</param>
        /// <param name="IfNoneMatch">The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource.</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse<StudentSpecialEducationProgramAssociation> GetStudentSpecialEducationProgramAssociationsById(string id, string IfNoneMatch= null) 
        {
            var request = new RestRequest("/studentSpecialEducationProgramAssociations/{id}", Method.GET);
            request.RequestFormat = DataFormat.Json;

            request.AddUrlSegment("id", id);
            // verify required params are set
            if (id == null ) 
               throw new ArgumentException("API method call is missing required parameters");
            request.AddHeader("If-None-Match", IfNoneMatch);
            request.AddHeader("Accept", "application/json");
            var response = client.Execute<StudentSpecialEducationProgramAssociation>(request);

            return response;
        }
        /// <summary>
        /// Updates or creates a resource based on the resource identifier. The PUT operation is used to update or create a resource by identifier.  If the resource doesn't exist, the resource will be created using that identifier.  Additionally, natural key values cannot be changed using this operation, and will not be modified in the database.  If the resource &quot;id&quot; is provided in the JSON body, it will be ignored as well.
        /// </summary>
        /// <param name="id">A resource identifier specifying the resource to be updated.</param>
        /// <param name="IfMatch">The ETag header value used to prevent the PUT from updating a resource modified by another consumer.</param>
        /// <param name="body">The JSON representation of the &quot;studentSpecialEducationProgramAssociation&quot; resource to be updated.</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse PutStudentSpecialEducationProgramAssociation(string id, string IfMatch, StudentSpecialEducationProgramAssociation body) 
        {
            var request = new RestRequest("/studentSpecialEducationProgramAssociations/{id}", Method.PUT);
            request.RequestFormat = DataFormat.Json;

            request.AddUrlSegment("id", id);
            // verify required params are set
            if (id == null || body == null ) 
               throw new ArgumentException("API method call is missing required parameters");
            request.AddHeader("If-Match", IfMatch);
            request.AddBody(body);
            request.Parameters.First(param => param.Type == ParameterType.RequestBody).Name = "application/json";
            var response = client.Execute(request);

            var location = response.Headers.FirstOrDefault(x => x.Name == "Location");

            if (location != null && !string.IsNullOrWhiteSpace(location.Value.ToString()))
                body.id = location.Value.ToString().Split('/').Last();
            return response;
        }
        /// <summary>
        /// Deletes an existing resource using the resource identifier. The DELETE operation is used to delete an existing resource by identifier.  If the resource doesn't exist, an error will result (the resource will not be found).
        /// </summary>
        /// <param name="id">A resource identifier specifying the resource to be deleted.</param>
        /// <param name="IfMatch">The ETag header value used to prevent the DELETE from removing a resource modified by another consumer.</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse DeleteStudentSpecialEducationProgramAssociationById(string id, string IfMatch= null) 
        {
            var request = new RestRequest("/studentSpecialEducationProgramAssociations/{id}", Method.DELETE);
            request.RequestFormat = DataFormat.Json;

            request.AddUrlSegment("id", id);
            // verify required params are set
            if (id == null ) 
               throw new ArgumentException("API method call is missing required parameters");
            request.AddHeader("If-Match", IfMatch);
            var response = client.Execute(request);

            return response;
        }
        }
    }

