Creationpatterns

	* Low binding Factory Method | Used in different type of nodes, with a base node factory, used in the same way for edges
	* Singleton, Prototype, Abstract Factory (pick 2) | Singleton is basically a anti-pattern also don't see any implementation that would make sense, forced into Prototype and Abstract Factory. Prototype will be used in Factory Method to get nodes. Abstract Factory is used for the Node and Edge factory.
  
Builder

	* Use Builder pattern | builder will be used to create the objects that will be drawn on the UI
	* Making multiple builders AND builder selfchecks (modular integrity) | builder for Nodes, builder for Edges, builder for Lines
  
Structurepatterns

	* Decorator, Facade, Adapter, Flyweight, Bridge, Proxy (pick 3) | Decorator pattern is used to change the behaviour of Nodes, Facade wont be used since no useful implementation can be found within the scope (no external library or API nor benefit from a context-specific input validation). A adapter also ain't neccesary because there are no existing classes which require a adapter to work with new ones. Flyweight could perhaps be used for drawing the nodes / edges on the UI, but unclear what the memory gain from that would be. Bridge pattern could be implemented just for the sake of adding another one, used for calling functions between nodes. Proxy pattern won't be used since there is no real big resource that's expensive or impossible to duplicate.
  
Composite

	* Use for implementing (16/20 marks) OR parsing (20/20 marks) composite circuits | Unsure
  
Behaviourpatterns

	* State, Mediator, Template Method (use all 3) | State pattern used for switching Strategies, Mediator used for communication between nodes, Template Method used for templates of the node/edge classes.
  
Visitor

	* Abstract Visitor with multiple diverse implementations | Unsure
  
Strategy

	* Multiple strategies, automatic selection of strategy in client | Strategies will be used in combination with the State pattern to automatically change the way gates/nodes work within the circuit.
  

GUI

	* GUI implemented | WPF with static spacing of nodes
	* Inputs can be changed in UI | With a onclick event objects with variable input
	* Visible which nodes are connected | Using static lines between locations relative to the anchor of a node on the screen
	* Result/output of simulation is clearly visible | Hard to implement above 3 without this
	* Show intermediary results of simulation | Difficult without slowing the simulation down, perhaps a step-by-step option?

Functionality

	* Simulation can be restarted without reloading everything | Have a default state and a strategy to handle this
	* Delay times are correctly calculated | Count steps, count the appropritate time per step show this in text somewhere
	* Application gives correct error message for infinite loop (test Circuit4_InfiniteLoops) | Done via validation in the parser
	* Application gives correct error message for unconnected nodes (test Circuit5_NotConnected) | Done via validation in the parser

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
