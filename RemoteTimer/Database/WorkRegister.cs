namespace RemoteTimer.Database
{
    public class WorkRegister : DatabaseProvider
    {
        public void RegisterWork(WorkRegistration registration)
        {
            registration.UsernameNavigation = ActiveUser;

            if (registration.Stop == null)
            {
                DBContext.Add(registration);
            }
            else
            {
                WorkRegistration? result = DBContext.WorkRegistrations
                        .SingleOrDefault(wr => wr.Start == registration.Start && wr.UsernameNavigation == ActiveUser);

                if (result != null)
                {
                    result.Stop = registration.Stop;
                }
            }

            DBContext.SaveChanges();
        }

        public void RegisterBreak(BreakRegistration registration)
        {
            registration.UsernameNavigation = ActiveUser;

            if (registration.Stop == null)
            {
                DBContext.Add(registration);
            }
            else
            {
                BreakRegistration? result = DBContext.BreakRegistrations
                        .SingleOrDefault(br => br.Start == registration.Start && br.UsernameNavigation == ActiveUser);

                if (result != null)
                {
                    result.Stop = registration.Stop;
                }
            }

            DBContext.SaveChanges();
        }
    }
}
