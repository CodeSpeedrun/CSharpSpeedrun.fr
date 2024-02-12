## C# Switch Statements Example

Switch statements in C# are a powerful control flow construct that allows for efficient selection among multiple options based on the value of an expression. Let's explore a practical example of using switch statements in a method for giving bonuses to employees based on their pay types.

```csharp
public void ProvideIncentive(float bonusAmount)
{
    Incentive = this switch
    {
        { PaymentCategory: EmployeePaymentCategoryEnum.Commission } => Incentive + 0.10F * bonusAmount,
        { PaymentCategory: EmployeePaymentCategoryEnum.Hourly } => Incentive + 40F * bonusAmount / 2080F,
        { PaymentCategory: EmployeePaymentCategoryEnum.Salaried } => Incentive + bonusAmount,
        _ => Incentive + 0 // Default case: no bonus
    };
}
```

## In this example:

- The method `ProvideIncentive` takes a `bonusAmount` parameter, representing the amount of bonus to be given.
- The `switch` statement is used to evaluate the `PaymentCategory` property of the current object instance.
- For each case, different bonus calculation formulas are applied based on the employee's payment category:
  - For employees with a payment category of `Commission`, the bonus is increased by 10% of the bonus amount.
  - For employees with a payment category of `Hourly`, the bonus is increased by a fraction of the bonus amount calculated based on the number of hours worked.
  - For employees with a payment category of `Salaried`, the bonus is increased by the entire bonus amount.
- The `_` case represents the default case, where no bonus is added.

