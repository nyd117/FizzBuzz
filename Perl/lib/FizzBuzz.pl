use strict;
use warnings;
use feature qw(say);

# FizzBuzz one liner

# toggle Fizz and Buzz strings when their respective conditions are satisfied.
# when no string has been defined due to unmet conditions then default to current value
say "Fizz" x!($_ % 3) . "Buzz" x!($_ % 5) || $_ for 1..100;