Creationpatterns

	* Low binding Factory Method
	* Singleton, Prototype, Abstract Factory (pick 2)
  
Builder

	* Use Builder pattern
	* Making multiple builders AND builder selfchecks (modular integrity)
  
Structurepatterns

	* Decorator, Facade, Adapter, Flyweight, Bridge, Proxy (pick 3)
  
Composite

	* Use for implementing (16/20 marks) OR parsing (20/20 marks) composite circuits 
  
Behaviourpatterns

	* State, Mediator, Template Method (use all 3)
  
Visitor

	* Abstract Visitor with multiple diverse implementations
  
Strategy

	* Multiple strategies, automatic selection of strategy in client
  

GUI

	* GUI implemented
	* Inputs can be changed in UI
	* Visible which nodes are connected
	* Result/output of simulation is clearly visible
	* Show intermediary results of simulation

Functionality

	* Simulation can be restarted without reloading everything
	* Delay times are correctly calculated
	* Application gives correct error message for infinite loop (test Circuit4_InfiniteLoops)
	* Application gives correct error message for unconnected nodes (test Circuit5_NotConnected)

Modularity

	* Filereader / Parser / Builder / UI are split
	* Goal of modules is clear
	* Filereader, parser and builder are well split without chain dependancies
	* Modules do checks and errorhandling themselves

Code

	* Application doesn't crash
		* Correct English
		* Methods have 1 responsibility
		* Classes have 1 clear goal
	* Useful commentary
