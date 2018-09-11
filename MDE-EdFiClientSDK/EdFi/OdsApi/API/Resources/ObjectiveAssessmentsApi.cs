using System;
using System.Collections.Generic;
using System.Linq;
using EdFi.OdsApi.Sdk;
using EdFi.OdsApi.Models.Resources;
using RestSharp;
  
namespace EdFi.OdsApi.Api.Resources 
{
    public class ObjectiveAssessmentsApi 
    {
        private readonly IRestClient client;

        public ObjectiveAssessmentsApi(IRestClient client)
        {
            this.client = client;
        }
      
        /// <summary>
        /// Retrieves resources based with paging capabilities (using the &quot;Get All&quot; pattern). This GET operation provides access to resources using the &quot;Get All&quot; pattern. In this version of the API there is support for paging.
        /// </summary>
        /// <param name="offset">Indicates how many items should be skipped before returning results.</param>
        /// <param name="limit">Indicates the maximum number of items that should be returned in the results (defaults to 25).</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse<List<ObjectiveAssessment>> GetObjectiveAssessmentsAll(int? offset= null, int? limit= null) 
        {
            var request = new RestRequest("/objectiveAssessments", Method.GET);
            request.RequestFormat = DataFormat.Json;

            if (offset != null)
                request.AddParameter("offset", offset);
            if (limit != null)
                request.AddParameter("limit", limit);
            request.AddHeader("Accept", "application/json");
            var response = client.Execute<List<ObjectiveAssessment>>(request);

            return response;
        }
        /// <summary>
        /// Retrieves resources matching values of an example resource (using the &quot;Get By Example&quot; pattern). This GET operation provides access to resources using the &quot;Get by Example&quot; search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).
        /// </summary>
        /// <param name="offset">Indicates how many items should be skipped before returning results.</param>
        /// <param name="limit">Indicates the maximum number of items that should be returned in the results (defaults to 25).</param>
        /// <param name="identificationCode">A unique number or alphanumeric code assigned to a space, room, site, building, individual, organization, program, or institution by a school, school system, a state, or other agency or entity.</param>
        /// <param name="assessmentTitle">The title or name of the assessment.  NEDM: Assessment Title</param>
        /// <param name="assessedGradeLevelDescriptor">The typical grade level for which an assessment is designed. If the test assessment spans a range of grades, then this attribute holds the highest grade assessed.  If only one grade level is assessed, then only this attribute is used. For example:  Adult  Prekindergarten  First grade  Second grade  ...</param>
        /// <param name="academicSubjectDescriptor">The description of the content or subject area (e.g., arts, mathematics, reading, stenography, or a foreign language) of an assessment.  NEDM: Assessment Content, Academic Subject</param>
        /// <param name="version">The version identifier for the test assessment.  NEDM: Assessment Version</param>
        /// <param name="parentIdentificationCode">A unique number or alphanumeric code assigned to a space, room, site, building, individual, organization, program, or institution by a school, school system, state, or other agency or entity.</param>
        /// <param name="maxRawScore">The maximum raw score achievable across all assessment items that are correct and scored at the maximum.</param>
        /// <param name="percentOfAssessment">The percentage of the Assessment that tests this objective.</param>
        /// <param name="nomenclature">Reflects the common nomenclature for an element.</param>
        /// <param name="description">A detailed description of the entity.</param>
        /// <param name="id"></param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse<List<ObjectiveAssessment>> GetObjectiveAssessmentsByExample(int? offset= null, int? limit= null, string identificationCode= null, string assessmentTitle= null, string assessedGradeLevelDescriptor= null, string academicSubjectDescriptor= null, int? version= null, string parentIdentificationCode= null, int? maxRawScore= null, double? percentOfAssessment= null, string nomenclature= null, string description= null, string id= null) 
        {
            var request = new RestRequest("/objectiveAssessments", Method.GET);
            request.RequestFormat = DataFormat.Json;

            if (offset != null)
                request.AddParameter("offset", offset);
            if (limit != null)
                request.AddParameter("limit", limit);
            if (identificationCode != null)
                request.AddParameter("identificationCode", identificationCode);
            if (assessmentTitle != null)
                request.AddParameter("assessmentTitle", assessmentTitle);
            if (assessedGradeLevelDescriptor != null)
                request.AddParameter("assessedGradeLevelDescriptor", assessedGradeLevelDescriptor);
            if (academicSubjectDescriptor != null)
                request.AddParameter("academicSubjectDescriptor", academicSubjectDescriptor);
            if (version != null)
                request.AddParameter("version", version);
            if (parentIdentificationCode != null)
                request.AddParameter("parentIdentificationCode", parentIdentificationCode);
            if (maxRawScore != null)
                request.AddParameter("maxRawScore", maxRawScore);
            if (percentOfAssessment != null)
                request.AddParameter("percentOfAssessment", percentOfAssessment);
            if (nomenclature != null)
                request.AddParameter("nomenclature", nomenclature);
            if (description != null)
                request.AddParameter("description", description);
            if (id != null)
                request.AddParameter("id", id);
            request.AddHeader("Accept", "application/json");
            var response = client.Execute<List<ObjectiveAssessment>>(request);

            return response;
        }
        /// <summary>
        /// Retrieves a specific resource using the values of the resource's natural key (using the &quot;Get By Key&quot; pattern). This GET operation provides access to resources using the &quot;Get by Key&quot; search pattern. The values of the natural key of the resource must be fully specified, and the service will return the matching result (if it exists).
        /// </summary>
        /// <param name="academicSubjectDescriptor">The description of the content or subject area (e.g., arts, mathematics, reading, stenography, or a foreign language) of an assessment.  NEDM: Assessment Content, Academic Subject</param>
        /// <param name="assessedGradeLevelDescriptor">The typical grade level for which an assessment is designed. If the test assessment spans a range of grades, then this attribute holds the highest grade assessed.  If only one grade level is assessed, then only this attribute is used. For example:  Adult  Prekindergarten  First grade  Second grade  ...</param>
        /// <param name="assessmentTitle">The title or name of the assessment.  NEDM: Assessment Title</param>
        /// <param name="identificationCode">A unique number or alphanumeric code assigned to a space, room, site, building, individual, organization, program, or institution by a school, school system, a state, or other agency or entity.</param>
        /// <param name="version">The version identifier for the test assessment.  NEDM: Assessment Version</param>
        /// <param name="IfNoneMatch">The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource.</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse<ObjectiveAssessment> GetObjectiveAssessmentByKey(string academicSubjectDescriptor, string assessedGradeLevelDescriptor, string assessmentTitle, string identificationCode, int? version, string IfNoneMatch= null) 
        {
            var request = new RestRequest("/objectiveAssessments", Method.GET);
            request.RequestFormat = DataFormat.Json;

            // verify required params are set
            if (academicSubjectDescriptor == null || assessedGradeLevelDescriptor == null || assessmentTitle == null || identificationCode == null || version == null ) 
               throw new ArgumentException("API method call is missing required parameters");
            if (academicSubjectDescriptor != null)
                request.AddParameter("academicSubjectDescriptor", academicSubjectDescriptor);
            if (assessedGradeLevelDescriptor != null)
                request.AddParameter("assessedGradeLevelDescriptor", assessedGradeLevelDescriptor);
            if (assessmentTitle != null)
                request.AddParameter("assessmentTitle", assessmentTitle);
            if (identificationCode != null)
                request.AddParameter("identificationCode", identificationCode);
            if (version != null)
                request.AddParameter("version", version);
            request.AddHeader("If-None-Match", IfNoneMatch);
            request.AddHeader("Accept", "application/json");
            var response = client.Execute<ObjectiveAssessment>(request);

            return response;
        }
        /// <summary>
        /// Creates or updates resources based on the natural key values of the supplied resource. The POST operation can be used to create or update resources. In database terms, this is often referred to as an &quot;upsert&quot; operation (insert + update).  Clients should NOT include the resource &quot;id&quot; in the JSON body because it will result in an error (you must use a PUT operation to update a resource by &quot;id&quot;). The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately.
        /// </summary>
        /// <param name="body">The JSON representation of the &quot;objectiveAssessment&quot; resource to be created or updated.</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse PostObjectiveAssessments(ObjectiveAssessment body) 
        {
            var request = new RestRequest("/objectiveAssessments", Method.POST);
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
        public IRestResponse<ObjectiveAssessment> GetObjectiveAssessmentsById(string id, string IfNoneMatch= null) 
        {
            var request = new RestRequest("/objectiveAssessments/{id}", Method.GET);
            request.RequestFormat = DataFormat.Json;

            request.AddUrlSegment("id", id);
            // verify required params are set
            if (id == null ) 
               throw new ArgumentException("API method call is missing required parameters");
            request.AddHeader("If-None-Match", IfNoneMatch);
            request.AddHeader("Accept", "application/json");
            var response = client.Execute<ObjectiveAssessment>(request);

            return response;
        }
        /// <summary>
        /// Updates or creates a resource based on the resource identifier. The PUT operation is used to update or create a resource by identifier.  If the resource doesn't exist, the resource will be created using that identifier.  Additionally, natural key values cannot be changed using this operation, and will not be modified in the database.  If the resource &quot;id&quot; is provided in the JSON body, it will be ignored as well.
        /// </summary>
        /// <param name="id">A resource identifier specifying the resource to be updated.</param>
        /// <param name="IfMatch">The ETag header value used to prevent the PUT from updating a resource modified by another consumer.</param>
        /// <param name="body">The JSON representation of the &quot;objectiveAssessment&quot; resource to be updated.</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse PutObjectiveAssessment(string id, string IfMatch, ObjectiveAssessment body) 
        {
            var request = new RestRequest("/objectiveAssessments/{id}", Method.PUT);
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
        public IRestResponse DeleteObjectiveAssessmentById(string id, string IfMatch= null) 
        {
            var request = new RestRequest("/objectiveAssessments/{id}", Method.DELETE);
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

