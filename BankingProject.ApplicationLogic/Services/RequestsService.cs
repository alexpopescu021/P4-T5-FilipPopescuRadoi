using System;
using System.Collections.Generic;
using System.Text;
using BankingProject.ApplicationLogic.Abstractions;
using BankingProject.ApplicationLogic.Model;

namespace BankingProject.ApplicationLogic.Services
{
    public class RequestsService
    {
        private readonly IRequestRepository requestRepository;

        public RequestsService(IRequestRepository requestRepository)
        {
            this.requestRepository = requestRepository;
        }

        public IEnumerable<Request> GetRequests()
        {
            return requestRepository.GetAll();
        }

        public IEnumerable<Request> GetRequestsByCustomerId(string id)
        {
            Guid idToSearch = Guid.Parse(id);
            return requestRepository.GetByCustomerId(idToSearch);
        }

        public Request GetRequestById(string id)
        {
            Guid idToSearch = Guid.Parse(id);
            return requestRepository.GetById(idToSearch);
        }
        public Request UpdateReq(Request request)
        {
            return requestRepository.Update(request);
        }
        public void AddRequest(Request request)
        {
            var req= requestRepository.Add(request);
        }
    }
}
