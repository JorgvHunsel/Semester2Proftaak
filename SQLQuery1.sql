SELECT Question.QuestionID, Question.CareRecipientID, Question.CategoryId, Question.Status, Question.Title, Question.Description, Question.Datetime, Question.Urgency, User.UserID, User.AccountType, User.FirstName, User.LastName, User.Birthdate, User.Sex, User.Email, User.Address, User.
FROM Question 
INNER JOIN [User] ON [User].UserID = [Question].CareRecipientID
INNER JOIN [Reaction] ON [Reaction].QuestionID = [Question].QuestionID;


