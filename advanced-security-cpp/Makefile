# Define the compiler
CXX = g++

# Define the target executable
TARGET = hello

# Define compile-time flags
CXXFLAGS = -Wall -Wextra -std=c++17

# Define all object files
OBJS = main.o

# Default rule to build the executable
all: $(TARGET)

# Rule to build the target executable
$(TARGET): $(OBJS)
	$(CXX) $(CXXFLAGS) -o $(TARGET) $(OBJS)

# Rule to build the main.o file
main.o: main.cpp
	$(CXX) $(CXXFLAGS) -c main.cpp

# Clean rule to remove generated files
clean:
	rm -f $(TARGET) $(OBJS)