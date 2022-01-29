namespace FitnessBL.Model
{
    /// <summary>
    /// User.
    /// </summary>
    [Serializable]
    public class User
    {
        #region Properties
        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gender.
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Birth date.
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Weight.
        /// </summary>
        public double Weight { get; set; }


        /// <summary>
        /// Height.
        /// </summary>
        public double Height { get; set; }

        //DateTime nowDate = DateTime.Today;
        //int age = nowDate.Year - birthDate.Year;
        //if (birthDate > nowDate.AddYears(-age)) age--;

        public int Age { get { return DateTime.Now.Year - BirthDate.Year; } }
        #endregion

        /// <summary>
        /// Create a new user.
        /// </summary>
        /// <param name="name"> Name. </param>
        /// <param name="gender"> Gender. </param>
        /// <param name="birthDate"> Birth date. </param>
        /// <param name="weight"> Weight. </param>
        /// <param name="height"> Height. </param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public User(string name, Gender gender, DateTime birthDate, double weight, double height)
        {
            #region Condition check
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("User name cannot be empty or null.", nameof(name));
            }

            if (gender == null)
            {
                throw new ArgumentNullException("Gender name cannot be null.", nameof(gender));
            }

            if (birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now)
            {
                throw new ArgumentException("Invalid date of birth.", nameof(birthDate));
            }

            if (weight <= 0)
            {
                throw new ArgumentException("The weight must not be less than or equal to zero.", nameof(weight));
            }

            if(height <= 0)
            {
                throw new ArgumentException("The height must not be less than or equal to zero.", nameof(height));
            }
            #endregion

            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }

#pragma warning disable CS8618 // Non-nullable property 'Gender' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public User(string name)
#pragma warning restore CS8618 // Non-nullable property 'Gender' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("User name cannot be empty or null.", nameof(name));
            }

            Name = name;
        }

        public override string ToString()
        {
            return $"{Gender} {Age}";
        }
    }
}
