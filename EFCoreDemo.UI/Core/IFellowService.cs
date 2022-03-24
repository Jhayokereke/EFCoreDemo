using AutoMapper;
using EFCoreDemo.UI.Entities;
using EFCoreDemo.UI.Models;
using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ILogger = Microsoft.Extensions.Logging.ILogger;

namespace EFCoreDemo.UI.Core
{
    public interface IFellowService
    {
        Task<bool> Register(RegisterFellowRequest request);
        Task<bool> Delete(string fellowId);
        Task<GetFellowResponse> Get(string fellowId);
        Task<IEnumerable<GetFellowResponse>> GetAll();
        Task<bool> Update(UpdateFellowRequest request);
    }

    public class FellowService : IFellowService
    {
        private readonly IFellowRepository _repo;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public FellowService(IFellowRepository fellowRepository, IMapper mapper, ILogger<FellowService> logger)
        {
            _repo = fellowRepository;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Delete(string fellowId)
        {
            try
            {
                return await _repo.DeleteFellowAsync(fellowId);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<GetFellowResponse> Get(string fellowId)
        {
            try
            {
                var resp = await _repo.FindFellowAsync(fellowId);
                return _mapper.Map<GetFellowResponse>(resp);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<GetFellowResponse>> GetAll()
        {
            try
            {
                _logger.LogInformation("Fetching all Fellows from database");
                var response = new List<GetFellowResponse>();
                var resp = await _repo.GetDotnetFellowsAsync();

                foreach (var fellow in resp)
                {
                    response.Add(_mapper.Map<GetFellowResponse>(fellow));
                }
                _logger.LogInformation("{@AllFellows}", response);
                return response;
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                return null;
            }
        }

        public async Task<bool> Register(RegisterFellowRequest request)
        {
            try
            {
                _logger.LogInformation("{@Request}", request);
                _logger.LogInformation("Creating user with firstname of {Firstname}", request.Firstname);
                var fellow = _mapper.Map<DotnetFellow>(request);

                return await _repo.AddFellowAsync(fellow);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.InnerException.Message ?? e.Message);
                return false;
            }
        }

        public async Task<bool> Update(UpdateFellowRequest request)
        {
            try
            {
                var fellowToUpdate = _mapper.Map<DotnetFellow>(request);

                return await _repo.UpdateFellowAsync(fellowToUpdate);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
