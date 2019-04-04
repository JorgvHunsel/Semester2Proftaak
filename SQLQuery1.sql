UPDATE [User]
SET FirstName = @FirstName, LastName = @LastName, Birthdate = @Birthdate, Sex = @Sex, Email = @Email, Address = @Address, PostalCode = @PostCode, City = @City
WHERE @userId = User.UserID