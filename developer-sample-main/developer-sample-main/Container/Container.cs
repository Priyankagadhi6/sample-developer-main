using System;
using System.Collections.Generic;

namespace DeveloperSample.Container
{
    public class Container
    {
        private readonly Dictionary<Type, Type> _bindings = new Dictionary<Type, Type>();

        public void Bind(Type interfaceType, Type implementationType)
        {
            
            if (interfaceType == null || !interfaceType.IsInterface)
            {
                throw new ArgumentException("interfaceType must be a valid interface type.");
            }

                      if (implementationType == null || !interfaceType.IsAssignableFrom(implementationType))
            {
                throw new ArgumentException("implementationType must be a valid type that implements the interface.");
            }

            _bindings[interfaceType] = implementationType;
        }

        public T Get<T>()
        {
            if (!_bindings.TryGetValue(typeof(T), out var implementationType))
            {
                throw new InvalidOperationException($"No binding registered for interface {typeof(T)}.");
            }
            return (T)Activator.CreateInstance(implementationType);
        }
    }
}
