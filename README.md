# Kata-Object-Calisthenics

***Acceptance tests***

**Scenario** : Can depose and withdraw money on my account

```
Given a client makes a deposit of 1000€ on 10-01-2012
  And a deposit of 2000€ on 13-01-2012
  And a withdrawal of 500€ on 14-01-2012
When she prints her bank statement
Then she would see
Date       || Credit    || Debit  || Balance
14/01/2012 ||           || 500.00 || 2500.00
13/01/2012 || 2000.00   ||        || 3000.00
10/01/2012 || 1000.00   ||        || 1000.00
```

**Scenario** : Can depose money on my account with different currencies

```
Given the exchange rate USD to EUR is 0.8924 
Given a client makes a deposit of 1000€ on 10-01-2012
  And a deposit of 2000$ on 13-01-2012
When she prints her bank statement
Then she would see
Date       || Credit    || Debit  || Balance
14/01/2012 ||           || 500.00 || 2500.00
13/01/2012 || 2000.00   ||        || 3000.00
10/01/2012 || 1000.00   ||        || 1000.00
```

**Scenario** : Can withdraw money on my account with different currencies

```
Given the exchange rate EUR to USD is 1.206 
Given a client makes a deposit of 1000€ on 10-01-2012
    And a withdrawal of 500$ on 14-01-2012
When she prints her bank statement
Then she would see
Date       || Credit    || Debit  || Balance
14/01/2012 ||           || 500.00 || 2500.00
13/01/2012 || 2000.00   ||        || 3000.00
10/01/2012 || 1000.00   ||        || 1000.00
```
