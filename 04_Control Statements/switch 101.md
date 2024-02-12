public void GiveBonus(float amount)
{
Pay = this switch
{
{PayType: EmployeePayTypeEnum.Commission }
=> Pay += .10F * amount,
{PayType: EmployeePayTypeEnum.Hourly }
=> Pay += 40F * amount/2080F,
{PayType: EmployeePayTypeEnum.Salaried }
=> Pay += amount,
_ => Pay+=0
};
}