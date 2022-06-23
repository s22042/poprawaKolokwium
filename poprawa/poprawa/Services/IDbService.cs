using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using poprawa.Models.DTO;
using poprawa.Models;


namespace poprawa.Services
{
    public interface IDbService
    {
        public Task<GetTeam> GetTeams(string id);
        public Task<bool> CheckIfInOrganization(Member member, Team team);
        public Task AddUser(Member member, Team team);
    }
}
