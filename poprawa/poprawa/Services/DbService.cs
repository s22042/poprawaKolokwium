using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using poprawa.Models;
using poprawa.Models.DTO;


namespace poprawa.Services
{
    public class DbService : IDbService
    {
        readonly MainDbContext _context;
        public DbService(MainDbContext mainDbContext)
        {
            _context = mainDbContext;
        }

        public async Task<bool> CheckIfInOrganization(Member member, Team team)
        {
            var g = _context.Organizations.Where(m => m.OrganizationID == team.OrganizationId && m.OrganizationID == member.OrganizationId).FirstOrDefault();
            if (g != null)
                return true;
            return false;
        }

        public async Task<GetTeam> GetTeams(string id)
        {
            return await _context.Teams.Include(m => m.Memberships)
                .Where(m => m.TeamId==Int32.Parse(id))
                .Select(m => new GetTeam {Name= m.TeamName, Organization=m.OrganizationId, Members=m.Memberships, Desc=m.TeamDescription}).SingleOrDefaultAsync();
     
    
        }
        public async Task AddUser(Member member, Team team)
        {
            await _context.AddAsync(new Membership { MemberId = member.MemberId, TeamId = team.TeamId, MembershipDate = DateTime.Now });
            await _context.SaveChangesAsync();
        }

    }
}
