
Smart Electricity Billing & Summary System (EnergyTech)
Build a console application that computes monthly electricity bills for multiple consumers and produces a month-end summary report.
Functional requirements:
1.	Read the number of consumers N.
2.	For each consumer read:
o	ConsumerID (string)
o	UnitsConsumed (integer)
o	ConnectionType (code: 1 = Domestic, 2 = Commercial)
3.	Compute the base charge per consumer using the following slabs:
o	Domestic: 0–100 → ₹1.50/unit; 101–300 → ₹2.50/unit; >300 → ₹4.00/unit
o	Commercial: 0–200 → ₹5.00/unit; 201–500 → ₹6.50/unit; >500 → ₹8.00/unit
4.	Apply additional rules:
o	Environmental surcharge = 3% of base charge
o	If units > 500, add penalty ₹200
o	If total after surcharge & penalty > ₹2000, apply discount 5% on the total
5.	For each consumer output:
o	ConsumerID, ConnectionType (human readable), UnitsConsumed, BaseCharge, Surcharge, Penalty (if any), Discount (if any), FinalBill
6.	After processing all consumers, print a summary:
o	Total consumers processed
o	Total revenue (sum of final bills)
o	Highest single bill amount and corresponding ConsumerID
o	Count of Domestic vs Commercial consumers
Sample input (format is flexible):
N = 3
C001 120 1
C002 560 2
C003 80 1
Sample output (representative):
C001 Domestic Units:120 Base: 1.50*120=180.00 Surcharge:5.40 Penalty:0 Discount:0 Final:185.40
C002 Commercial Units:560 Base: ... Penalty:200 Discount:... Final: ...
C003 Domestic ...
--- Summary ---
Total Consumers:3
Total Revenue: ₹XXXX.XX
Highest Bill: C002 ₹XXXX.XX
Domestic:2 Commercial:1
