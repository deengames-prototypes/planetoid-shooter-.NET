# Planetoid Shooter

A 2D, top-down shooter in a constrained area, similar to Amorphous+. Created in MonoGame; moddable in Javascript, via ClearScript; data-driven for easy editing.

# Rough Notes

AXIOMS:
- Fun and interesting
- Data driven architecture
- Moddable core and code -- JS (ClearScript)

CORE GAMEPLAY
- Infinite shooter where you're stuck in an arena fighting hordes of enemies.
- Enemies randomly generate (including their power) based on difficulty, and attack you
- Top-down is easier to animate and stuff, we can do sideways mode later...
- You pick up guns, mods, parts, or something (eg. laser gun, flame thrower)
- You can mod stuff -- turn laser into a double-laser (changes energy consumption) -- trade-off is usually "more power? more energy cost"
- Eventually, the queen comes out, and you defeat her to win.
- It's like Amorphous+.

OTHER GAMEPLAY
- Up to two weapons at once, switch
- Other power-ups, like a sentry gun, shield, etc.
- When you die, you die permanently
- Maybe walking speed and energy max/growth-rate is based on your level?
- Helpers can include kinetic (walking => faster recharge), solar (slow recharge if it's not cloudy/raining/night-time) ...

LATER MODS
- You can collect resources, like crystals
- You can build stuff, like sentries, a base, a research lab (capture live specimens?), etc.
- You need to explore and find the queen

EDUCATIONAL VALUE
- Biology: enemies are based on real (gigantified) bugs and creatures. You need to know their weaknesses. It's not just that uber laser kills everything, some enemies are laser-proof. Some succumb to fire, even if it's a low-level flamethrower.
- Science: weapons are based on real tech (lasers, rockets, etc.)
- Energy: a bit about heat vs. output, and kinetic vs. solar energy

