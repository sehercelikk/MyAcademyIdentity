using Microsoft.AspNetCore.Identity;

namespace EmailApp.Validations;

public class CustomErrorDescriber : IdentityErrorDescriber
{
    public override IdentityError PasswordRequiresDigit()
    {
        return new IdentityError
        {
            Code = "PasswordRequiresDigit",
            Description = "Şifre en az 1 rakam içermelidir"
        };
    }

    public override IdentityError PasswordRequiresLower()
    {
        return new IdentityError
        {
            Code = "PasswordRequiresLower",
            Description = "Şifre en az 1 küçük harf içermelidir."
        };
    }

    public override IdentityError PasswordRequiresUpper()
    {
        return new IdentityError
        {
            Code = "PasswordRequiresUpper",
            Description = "Şifre en az 1 büyük harf içermelidir."
        };
    }

    public override IdentityError PasswordTooShort(int length)
    {
        return new IdentityError
        {
            Code = "PasswordTooShort",
            Description = $"Şifre en az {length} karakter olmalıdır."
        };
    }

    public override IdentityError PasswordRequiresNonAlphanumeric()
    {
        return new IdentityError
        {
            Code = "PasswordRequiresNonAlphanumeric",
            Description = "Şifre en az bir özel karakter(*,!,+,% vb.) içermelidir."
        };
    }

    public override IdentityError DuplicateUserName(string userName)
    {

        return new IdentityError
        {
            Code = "DuplicateUserName",
            Description = $"{userName} kullanıcı adı daha önce kullanılmıştır."
        };
    }

    public override IdentityError DuplicateEmail(string email)
    {
        return new IdentityError
        {
            Code = "DuplicateEmail",
            Description = $"{email} email adresi ile daha önce kayıt yapılmıştır."
        };
    }
    
}
